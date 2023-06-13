# Chat Application

This is a chat application built using Dot Net C# 7.0. It provides a simple web-based chat interface for users to send messages to each other. The application utilizes a Web API backend for handling message storage and retrieval.

## Features

- Send messages between users in real-time
- View chat history
- User-friendly interface
- Responsive design for different devices

## Technologies Used

- Dot Net C# 7.0
- ASP.NET Core Web API
- HTML, CSS, and JavaScript
- Bootstrap (for UI styling)
- jQuery (for client-side interactions)

## Getting Started

To run this application locally, follow these steps:

1. Clone the repository: `git clone <repository_url>`
2. Open the solution in Visual Studio or your preferred IDE.
3. Build the solution to restore dependencies.
4. Start the application using the IDE's debugging tools or by running `dotnet run` in the project directory.
5. Access the application in your web browser at `http://localhost:<port_number>`

## API Endpoints

- `GET /api/chat/getchathistory`: Retrieves the chat history.
- `POST /api/chat/sendmessage`: Sends a new message.

## Configuration

- CORS: The application is configured to allow cross-origin requests from `http://localhost:8080`. Adjust the CORS policy in the `Startup.cs` file if needed.

## Contributing

Contributions to this project are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
