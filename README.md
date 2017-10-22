# SmartAirports
I will share all information you need to know. Fly, buy, pay and explore the world with us


Our navigation system uses Bluetooth triangulation based on Raspberry Pi beacons placed on strategic places creating a grid or a map of position of the passengers using our application. Our Android application is searching for advertising data from beacons and calculate where a passenger is located and based on his information (retreived from boarding pass or from manually entered information) we can show him where he is supposed to go and which way is the shortes. We allow him to buy deads in the shops or to use any service and he will pay using his temporary account fixed to his boarding pass.

We have used Raspberry Pi and Python code to advertise any information as a Bluetooth Beacon. Location of all beacons is calculated and stored in an airport system and we share airport map with all users. We have used Xamarin and have written a code in C# and the product is application with user login, QR code reading, retreiving and commiting data to MSSQL databese. Second part of mobile application is written in Java using Android SDK and Android-Beacon-Scanner code.
