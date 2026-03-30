# .NET MAUI Messaging application
This is a small messaging application I built to showcase my .NET MAUI expertise.\
The original task was this:
# Messaging and Receiving System
Implementation of a simple messaging system where registered users can communicate with each other.

## 1. User Management
- Registration with the following data:
  - Username (must be unique)
  - Password (minimum 6 characters, must include uppercase and lowercase letters, and a number)
  - Full Name
- Login

## 2. Messaging
- Users can send messages to each other.
- Rate Limit: A user can send a maximum of 5 messages per day.

## 3. Message Management
- Users can view their own messages (inbox and/or outbox list – implementation is flexible).
- Message Status: Read / Unread
- Status must be modifiable (e.g., marking as read).

## 4. User List
- Display a list of all users registered in the system.
- The messaging can be initiated from this list.
- Settings:
  - Users can hide themselves from the list.
  - A user can block other users (blocked users cannot send them messages).

## Extras (Optional)
- Send a single message to multiple recipients.
- Send messages via email.
- Favorites List (ability to bookmark specific users).
- Scheduled messaging (sending at a later time).

# Screenshots
## Login interface
<img width="786" height="593" alt="image" src="https://github.com/user-attachments/assets/fe158dcd-2de0-43e0-b185-80e319fa7471" />\
## Register page (with validation errors)
<img width="786" height="593" alt="image" src="https://github.com/user-attachments/assets/f333ceba-4df5-4802-a6e3-bdd48856a21a" />\
## Users page
The active user can select which other user to message here. Right-clicking on a User also gives options to add/remove that user to/from favorites, or mark the last message as read/unread. They can also disable their visibility to other users, so they won't appear to others on this interface. They can also block other users, which does the same thing, but only for that specific user.\
<img width="786" height="593" alt="image" src="https://github.com/user-attachments/assets/3115b8a4-5c63-424a-8d64-5422186c9687" />
<img width="786" height="593" alt="image" src="https://github.com/user-attachments/assets/166f9f38-0eb3-4e3c-845c-de2e9a61c9e6" />
## Messaging interface
The user is able to send messages here. As there is a rate-limit in the requirements, after 5 messages the Entry and Send button will be disabled for that day.
<img width="962" height="909" alt="image" src="https://github.com/user-attachments/assets/a6c7ca82-ca6a-494d-99f6-5f79b8964dd2" />

## Light Mode
The app's styles are correctly applied, both Light and Dark modes are functional and automatically follow system theme settings.
<img width="786" height="593" alt="image" src="https://github.com/user-attachments/assets/49017d2e-8ff2-4c5d-8959-c0a302363129" />
<img width="786" height="593" alt="image" src="https://github.com/user-attachments/assets/527bb88c-57d2-4d98-8fa8-31fcf0d94d7c" />
<img width="786" height="593" alt="image" src="https://github.com/user-attachments/assets/6d1f5e0b-b6b5-4573-a0a9-fafa48e6bbc7" />
<img width="881" height="814" alt="image" src="https://github.com/user-attachments/assets/bde164f3-ec1a-4b28-a860-0d961e7f033a" />


