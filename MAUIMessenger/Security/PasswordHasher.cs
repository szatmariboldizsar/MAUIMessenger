using System.Security.Cryptography;
using System.Text;
using Konscious.Security.Cryptography;

public static class PasswordHasher
{
    private const int SaltSize = 16;
    private const int HashSize = 32;
    private const int Iterations = 3;
    private const int MemorySize = 65536; // 64MB
    private const int Parallelism = 4;

    public static string Hash(string password)
    {
        // 1. Generate a cryptographically random salt
        byte[] salt = new byte[SaltSize];
        RandomNumberGenerator.Fill(salt);

        // 2. Compute the hash
        using var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
        {
            Salt = salt,
            DegreeOfParallelism = Parallelism,
            Iterations = Iterations,
            MemorySize = MemorySize
        };

        byte[] hash = argon2.GetBytes(HashSize);

        // 3. Combine into a single string for storage
        // Format: {MemorySize}:{Iterations}:{Parallelism}:{SaltBase64}:{HashBase64}
        return $"{MemorySize}:{Iterations}:{Parallelism}:{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
    }

    public static bool Verify(string password, string stored)
    {
        try
        {
            // 1. Split the stored string to extract parameters and salt
            var parts = stored.Split(':');
            if (parts.Length != 5) return false;

            int memory = int.Parse(parts[0]);
            int iterations = int.Parse(parts[1]);
            int parallelism = int.Parse(parts[2]);
            byte[] salt = Convert.FromBase64String(parts[3]);
            byte[] expectedHash = Convert.FromBase64String(parts[4]);

            // 2. Hash the input password with the SAME parameters and salt
            using var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = parallelism,
                Iterations = iterations,
                MemorySize = memory
            };

            byte[] actualHash = argon2.GetBytes(HashSize);

            // 3. Fixed-time comparison to prevent timing attacks
            return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
        }
        catch
        {
            return false;
        }
    }
}