CompaniOn, an AI-based companion application designed to improve both the emotional and cognitive well-being of elderly users. The system aims to reduce loneliness through empathetic conversational interaction, foster cognitive engagement through reminders and dialogue, strengthen family bonds via seamless communication tools, and enhance safety by integrating real-time health monitoring, location tracking, and emergency alerts.

The application itself, even though it uses a third-party API as a chatbot functionality, consists as a rather complex mix of different knit up technologies that are as follows: 

•	Chatbot mechanism through a 3D animated model.

•	.NET - A C# Framework used for creating the backend endpoint that oversees communicating with a traditional SQL based database and then bringing that information back to the UI in a presentable way to the user.

•	User UI – An interface made in Flutter, designed to connect the 3D AI chatbot to the user together with the endpoints created in .NET. It is also important to note the fact that the application is focused on 2 user groups, mainly elderly users and their family members or caregivers, therefore the UI part of the application consists of 2 separate designs where only the elderly user have access to the chatbot mechanisms of the 3D animated model, while the family members have more of an overview design from which they can control and monitor the elderly user.

•	Location Tracking: Continuously monitors and records the user’s real-time geographic position to support caregivers and ensure safety, especially in cases of disorientation or wandering.

•	SOS Notifications: Enables users to send immediate emergency alerts to predefined contacts or services, including their current location, with a single tap or voice command. 

All components previously outlined, are depicted and further elaborated in the following image.
<img width="525" height="305" alt="image" src="https://github.com/user-attachments/assets/8ea57d36-e1b4-47d9-ad8b-b0416d2f0fff" />
