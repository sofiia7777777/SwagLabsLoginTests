Launch URL: https://www.saucedemo.com/

UC-1 Test Login form with empty credentials: 
- Type any credentials into "Username" and "Password" fields. 
- Clear the inputs. 
- Hit the "Login" button. 
- Check the error messages: "Username is required".

UC-2 Test Login form with credentials by passing Username: 
- Type any credentials in username. 
- Enter password. 
- Clear the "Password" input. 
- Hit the "Login" button. 
- Check the error messages: "Password is required".

UC-3 Test Login form with credentials by passing Username & Password: 
- Type credentials in username which are under Accepted username are sections. 
- Enter password as secret sauce. 
- Click on Login and validate the title "Swag Labs" in the dashboard.

Provide parallel execution, add logging for tests and use Data Provider to parametrize tests. 
Make sure that all tasks are supported by these 3 conditions: UC-1; UC-2; UC-3. 
Please, add task description as README.md into your solution! 

To perform the task use the various of additional options: 
- Test Automation tool: Selenium Web Driver, 
- Browsers: 
  1) Firefox, 
  2) Chrome; 
- Locators: CSS; 
- Test Runner: xUnit; 
- (Optional) Patterns: 
  1) Factory method, 
  2) Abstract Factory, 
  3) Chain of responsibility, 
- [Optional] Test automation approach: BDD; 
- Assertions: Fluent Assertion; 
- [Optional] Loggers: SeriLog

# Please note:
This project uses Serilog to write logs to a file. By default, the logs are saved in a file named log.txt, located at:
C:\\Automation_Testing_C#\\SwagLabsLoginTests\\Utils\\log.txt
You will need to change the log file path to a location that is accessible on your machine.