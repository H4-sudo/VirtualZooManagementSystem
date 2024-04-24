# VirtualZooManagementSystem

## Design Desisions

- Due to the projects outcomes that were expected, I opted for the option of using a database to create my data backend
- A simple enough GUI making use of the `MessageBox` method to show some needed information, like an animal's energy, hunger and thirst.
- The `AddNewAnimal` form creates a new animal object in the database. It makes use of a text input field, a number box and radio buttons to select the animal type.
- The `FeedAnimals` form uses the lists from the database to show all the animals that are currently in the virtual zoo.
- The `SeeAllAnimals` form uses a query to the database that shows all the animals in the database.

## Classes

- The `Animal` class makes use of a generic animal class, which serves as a building block for the inherited classes.
- The `Animal` class uses interfaces for the use of the different animal methods, such as eating, sleeping and drinking.
- It also has animal sounds, very generic, but does the job.

## Limitations

- As this project had only a few weeks of time to complete, the project isn't as polished as it should be.
- A know bug is that the `Tend to an Animal` section has a problem with adding new animals, but after exiting the program and relaunching it, it works as intended.
- As we haven't started with any of the implementations contained within the project it isn't as perfect as I would hope.
- Using Winforms to create the GUI unfortunately creates a single platform product, which in turn makes it inferior to other implementations.
- The Microsoft Documentation while full, has limited knowledge transfer, however, it helped implementing the required methods.

## Database

- The database used is from my local machine, it should be noted that if you wanted to make the program run without any issues, you should consider creating your own database and run the sql query within the project.
- Remember to change the connection string to your database to ensure that the database will work.

## Development notes

- Luckily as a simple management system it works as inteded for the most part, this will not be abandoned, however the development will continue after the marks have been released.
- Any suggestions will be greatly appreciated.
