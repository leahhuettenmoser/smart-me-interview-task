1. Clone the repo from https://github.com/leahhuettenmoser/smart-me-interview-task
    - You can refactor all provided code as much or as little as you want. 
    - While solving the tasks, think about code quality, and document improvements you would make when given more time.
2. Create a controller `CitiesController`.
    - Making a HTTP GET request to `/cities` should list all cities and their population.
3. Extend controller `CantonsController`.
    - Making a HTTP GET request to `/cantons` should list all cantons and their total population.
4. Making a HTTP POST request to `/cities?name=new&population=23564&canton=Bern` should add the city, but only if the canton exists.  
    - The following HTTP response status codes should be returned:  
        - Canton does not exist => NotFound (404)  
        - Request is successful => Ok (200)  
    - The controllers in 3. & 4. should still return valid data after adding a new city.
5. Debug the pre-written methods based on the following problem statement:
    - For this, imagine that a web application exists to manage the population of cantons. 
    It uses the `Get` and `UpdateCantonPopulation` methods in the `CantonsController` to retrieve the Canton exactly once 
    when loaded and to save the whole canton with the changes. For this task, you can assume that the webapp does not exhibit faulty behaviour.
    - Document your steps to analyze the problem, and what solutions you would implement to analyze and/or mitigate this problem.
    - A large canton reports that administrators in their principalities sometimes have trouble saving the new population total of the principalities they manage. Support has created the following description for you:
        - *"Sometimes, independently of user-account or computer, updating the values seems to work, but when refreshing the page a bit later the values have been reset to the old values"*
6. Consider validation on the requests you implemented. What validation would make sense? How would you handle requests that don't pass validation?
7. Imagine the data source is a database and the usage of the API is very read-heavy.
    - Write down how the performance could be improved.