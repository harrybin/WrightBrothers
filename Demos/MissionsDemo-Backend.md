# 🛩️ GitHub Copilot Demos – Wright Brothers Backend REST API

## Estimated time to demo

- 60 minutes

> [!IMPORTANT] 
> This is used for GitHub Copilot Fundamentals trainings.

This demo is designed to showcase GitHub Copilot's capabilities in a fun and engaging way. It's a full flight simulation experience, so buckle up and enjoy the ride!

## Demo 1: Plane Inspection – Explain the Codebase

Explore the codebase to understand the project structure and functionality.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
   >
   > ```prompt
   > @workspace What is this project about, what's the domain, tech stack, and overall functionality?
   > ```

Find out the top security vulnerabilities or issues present in the project codebase.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > @workspace Provide a brief overview of the top security vulnerabilities or issues present in the project codebase with a focus on the most critical.
   > ```

Look at just a single file to understand its purpose and functionality.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > @workspace What does the PlanesController do?
   > ```

---

## Demo 2: Airplane Docking – Add New Flight Model

- Open 'PlanesController.cs' file.

**Task**
- Add 4 additional planes to list.

---

## Demo 3: Test Flight – Autocompletion and Suggestions

Start typing the following to trigger Copilot suggestions:

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > [HttpGet("count/{count}")]
   > ```

---

## Demo 4: Test Flight Accelerate – Comments to Code

- Navigate to `[HttpPost]` method in `PlanesController.cs`.

- Use Copilot `Comments to Code` to:

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > // Return BadRequest if plane already exists
   > ```

- Navigate to end of the SetupPlanesData() method.

- Use `Copilot Inline Chat` (`Ctrl + I`) to:

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > Create a new method called SearchByName to search for planes by name using a simple string input
   > ```

---

## Demo 5: Testing Your Flying Style – Logging Consistency

Add `_log` statements in these locations:

- Inside `GetById` method (after first `{`)

- Inside `SearchByName` method (after first `{`)

---

## Demo 6: Complete the Wright Brothers Fleet

- Open `Planes.cs`.
- Add `ImageUrl` property to the `Plane` class.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
   >
   > ```prompt
   > public string ImageUrl { get; set; }
   > ```

- Keep the file `Planes.cs` open.

- Open `PlanesController.cs`.

- Use `Copilot Inline Chat` (`Ctrl + I`) to:

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > Add the new ImageUrl property to each plane and add the next 2 additional planes to complete the Wright Brothers Fleet.
   > ```

GitHub Copilot used the information on the neighboring `Plane` class to add the `ImageUrl` property.

### Using Edit Mode

- Add Files `Plane.cs`, `PlanesController.cs`, and `PlanesControllerTests.cs` to working set.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > First, add a new property called ImageUrl to the planes model. 
   > Next, update each plane to include ImageUrl.  
   > Then, add 2 more planes to complete the Wright Brothers Fleet.  
   > Finally, create unit tests to test the ImageUrl property.
   > ```

---

## Demo 6.5 – Implementing the PUT Endpoint from Image

Your architect has already defined the contract for a new API endpoint: `PUT /planes/{id}`. Now it's your job to implement it.

This time, instead of generating code from scratch, you’ll use **GitHub Copilot Edits** and describe what you want based on the visual API spec provided in the screenshot.

- Add Files `PlanesController.cs` to working set.

- Right-click the image below and choose **Copy Image**.:

    <img src="./Images/Screenshot-PlanesPUT_API.png" width="750">

- Paste the image directly into the **GitHub Copilot Edits** chat window.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Create this API endpoint from the screenshot and append to end of #file:PlanesController.cs, after the existing code.
   > ```

- Review the Copilot-generated `PUT` method. It should:

   * Accept a plane ID as a route parameter.
   * Accept a `Plane` object in the request body.
   * Update the matching plane in the in-memory list.
   * Return HTTP 200 OK with the updated plane if successful.

> [!NOTE]
> Copilot is reading the shape of the method from your prompt and applying it directly into your controller. This mirrors a real-world scenario where teams pass specs via tickets or mockups.

---

## Demo 7: Pre-takeoff Pilot Checks – Completing Unit Tests

- Open `PlanesController.cs`

- Highlight the `GetById` method and use Copilot Inline Chat (`Ctrl + I`) to:

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Generate unit tests for this method including all edge cases.
   > Append unit tests to the #file:PlanesControllerTests.cs file using the existing test structure and naming conventions.
   > Use the existing list of planes for test data.  
   > ```

> [!TIP]
> Make sure to retype `#file:PlanesControllerTests.cs` to properly reference the file.

---

## Demo 8: Creating Simple Unit Tests – New Test Controller

- Add Files `FlightsController.cs` and `PlanesControllerTests.cs` to working set.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Create a new test class for the FlightsController.cs based on the style of PlanesControllerTests.cs.
   > Ensure that the tests cover all possible scenarios, including edge cases.
   > ```

---

## Demo 9: Creating Robust Tests – Search Scenarios

- Add files `Plane.cs`, `PlanesController.cs`, and `PlanesControllerTests.cs` to working set.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Generate new unit tests for the following scenarios:
   > - Specific search for "Wright Flyer III"
   > - General search for "Wright"
   > - Case-insensitive search for "wright flyer"
   > - Search with extra spaces for " Wright flyer "
   >
   > # Technical Details
   > - Use SetupPlanesData and SearchByName from PlanesController.cs
   > - Add 5 planes based on Wright Brothers in Plane.cs
   > - Ensure at least 3 named "Wright Flyer"
   > - Use [Theory] and FluentAssertions
   > - Append new test methods for PlanesControllerTests.cs
   > - Use the existing list of planes for test data.
   > ```

> [!TIP]
> Make sure to have the 'SetupPlanesData()' and 'SearchByName()' method to the 'PlanesController.cs' file.

---

## Demo 10: Fix Broken Tests if Broken

- Add Files `Plane.cs`, `PlanesController.cs`, and `PlanesControllerTests.cs` to working set.

- Some tests from previeus step may fail (case-insensitive and whitespace).

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Fix the SearchByName method based on the failing tests in #file:PlanesControllerTests.cs
   > ```

---

## Demo 11: Ascending to the Clouds – Creating Controllers

- Create new controllers, unit tests, and seed data for the AirfieldController. Run all tests and fix any issues.

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
>
> ```prompt
> Goal: Create an AirfieldController with CRUD operations based on Airfield.cs, matching PlanesController.cs style.
>
> Details:
> - Implement full CRUD following existing patterns.
> - Seed 3 historical Wright Brothers airfields (idempotent).
> - Add AirfieldControllerTests mirroring PlanesControllerTests.cs; cover happy paths + edge cases.
> - Use xUnit only (no FluentAssertions); add one-line explanation comment per test.
> - Run: dotnet build and dotnet test -l:"console;verbosity=normal".
> - On failures: apply minimal fixes, show unified diffs, rerun (max 2 attempts).
> - Output: list of changed/created files + brief change summary.
> - Constraints: no renaming or refactoring unrelated files; keep namespaces consistent.
> ```

---

## Demo 12: Refactor Airfield Controller with Modern C#

- Refactor the controllers and unit tests.

- Add Files `Airfield.cs`, `AirfieldController.cs`, and `AirfieldControllerTests.cs` to working set.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Refactor AirfieldController.cs and AirfieldControllerTests.cs to use async/await for all CRUD operations.
   > Include proper error handling and modern C# patterns.
   > Use async streams and pattern matching where appropriate
   > Use xUnit and add inline comments for clarity in each test
   > ```

---

## Demo 13: Logging Your Coding Journey – Docs & Comments

- Open `PlanesController.cs` file.

- Hightlight the **GetById()** method.

**Prompt (Quick Shortcut)**

- Use `Ctrl + I` 

- Use Copilot Inline Chat (`Ctrl + I`) to:

- Type `/doc`

- Type `Esc` to exit.

**Prompt (Persona)**

Use the prompting style of **Persona** to ask Copilot to write documentation for the API endpoint and add comments to the code.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > You are a technical writer. Write detailed documentation for this API endpoint, explaining its request parameters, response format, and usage
   > examples. Additionally, add detailed comments to the GetById method in the PlanesController class, explaining each step and including error handling.
   >
   > - Add inline comments to the method explaining each step.
   > ```

**Prompt (Chain of Thought)**

Use the prompting style of **Chain of Thought** to ask Copilot to explain the logic of the code step-by-step and add inline comments.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > Explain the logic of GetById step-by-step, then add inline comments for clarity.
   > ```

**Prompt (Meta Prompt for Custom Documentation Needs)**

Use the prompting style of **Meta Prompt** to ask Copilot how to generate clean, consistent code documentation for large projects.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
   >
   > ```prompt
   > What’s the best way to prompt you to generate clean, consistent code documentation for large projects?
   > ```

---

## Demo 14: Flying in Formation – Refactor Flight Status Logic

- Add Files `FlightsController.cs` to working set.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Refactor the UpdateFlightStatus method in FlightsController.cs.
   > 
   > ## Goals
   > - Keep controller logic clean (SRP)
   > - Move the status transition logic to a separate class called CanUpdateStatus in StatusValidation.cs stored in the models folder.
   > - Return BadRequest() if invalid transition
   > - Use CanUpdateStatus() to validate transitions
   > - Improve readability & maintainability
   > ```

---

## Demo 15: Parsing Flight Logs – Prompt Engineering

- Add Files `FlightsController.cs` to working set.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Create a new C# record type called FlightLog in FlightLog.cs, save in the models folder. FlightLog will parse FlightLogSignature.
   > 
   > ## Example
   > - 17121903-DEP-ARR-WB001
   >
   > ## Details
   > - 17 Dec 1903
   > - Departure: DEP
   > - Arrival: ARR
   > - Flight Number: WB001
   >
   > ## Requirements
   > - Implement Parse method
   > - Use DateTime.ParseExact (ddMMyyyy)
   > - Add try/catch for parsing errors
   > - Expose parsed result as read-only FlightLog property on Flight model.
   > ```
   
---

## Demo 16: Fixing a Flight Endpoint Bug

- Navigate to the correct directory for backend.

   ```text
   cd .\wright-brothers-backend\WrightBrothersApi\
   ```

- Run the backend project 

   ```text
   dotnet run
   ```

- Open `Flights.http` file.

- Reproduce a 200 status code:

   ```http
   GET http://localhost:1903/flights/2 HTTP/1.1
   ```

- Observe that the flight with ID `3` is returned instead of `2`. This indicates a bug in the API.

- Stop the backend project by pressing `Ctrl + C`

### Scenario

We found a bug in the API where requesting a specific flight by ID returns the wrong result.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
   >
   > ```prompt
   > There's a bug in the FlightsController. When I go to /flights/2, the app returns the wrong flight — it shows the flight with ID 3 instead of 2.
   > 
   > Please investigate and fix the bug so that the correct flight is returned when requesting by ID.
   > - Make any updates necessary to resolve this.
   > - I will manually re-run the backend project to verify the fix.
   > - Summarize the changes made to fix the bug.
   > ```

- Run the backend project 

   ```text
   dotnet run
   ```

## Demo 17: Flight Crash Investigation – Debugging with Copilot

- Run the backend project 

   ```text
   dotnet run
   ```

- Open `Flights.http` file.

- Reproduce a 200 status code:

   ```http
   POST http://localhost:1903/flights/1/takeFlight/75 HTTP/1.1
   ```

- Reproduce a 500 status code:

   ```http
   POST http://localhost:1903/flights/3/takeFlight/75 HTTP/1.1
   ```

### Option 1

In terminal, hightlight the exception message from **Error** to line number end of `FlightsController.cs`

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Fix error in #terminalSelection based on the exception message. I would like to see a friendly error message like "Cannot take flight due to detected fuel tank leak."
   > ```

### Option 2

In terminal, hightlight the exception message from **Error** to line number end of `FlightsController.cs`. Copy the exception message to clipboard and paste it into the Copilot Edits window.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Fix error based on the exception message. I would like to see a friendly error message like "Cannot take flight due to detected fuel tank leak."
   > ```

> [!TIP]
> GitHub Copilot will explain the issue and suggest a fix.

---

## Demo 18: Flight Data Recorder – Database Development

### Blueprinting the Aviation Database
Lay the **foundation** for the Wright Brothers' aviation database. Define the schema with basic structure.

- Add the following files to the working set:
    - `Pilot`
    - `Plane`
    - `Flight`
    - `Airfield`


   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Create a SQL Server DDL file named `AviationDB.sql` that defines a basic schema for a Wright Brothers aviation database.
   > 
   > ## Tables
   > - Pilot
   > - Plane
   > - Flight
   > - Airfield
   > 
   > ## DDL Statements
   > - Ensure proper data types (e.g., INT, VARCHAR, DATETIME).
   > ```

### Refining the Flight Plan 

Optimize the **database structure** by eliminating **redundant data**, improving **One-to-Many Relationships**, and enhancing **date usability**. Adjust tables for **better scalability** while keeping the database **lightweight and efficient**, ensuring data integrity and historical accuracy.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Update the AviationDB.sql file. Ensure a proper relational structure while maintaining clarity and efficiency.
   > 
   > ## Relationships
   > - Ensure proper One-to-Many relationships between tables.
   > - A Pilot can fly multiple Planes over time.
   > - A Plane can be assigned to multiple Airfields over time.
   > - A Plane can have multiple Flights recorded.
   > - An Airfield can host multiple Planes over time.
   > 
   > ## DDL Statements
   > - Define each table with primary keys, foreign keys, and constraints.
   > - Include FOREIGN KEY constraints for relationships.
   > ```

### Filling the Logbook with Historical Data

Populate the database with **realistic test data** based on the **Wright Brothers' aviation history (1903-1910)**. Generate **INSERT statements** that accurately represent early **flights, pilots, aircraft, and airfields** to create a **rich dataset**.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Refactor the AviationDB.sql to generate realistic test data for all tables in AviationDB.sql
   > 
   > ## Details
   > - Data should be historically accurate, reflecting Wright Brothers aviation history (1903-1910).
   > - Use INSERT statements to create a diverse and representative dataset with 3 records per table for historical accuracy.
   > ```

### Navigating Flight Details

Develop **stored procedures**, that retrieves **comprehensive flight information**. This ensures smooth **data retrieval**, much like a well-executed flight plan.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Update the AviationDB.sql file. Create stored procedures for the AviationDB to enhance data retrieval and reporting.
   > 
   > ## Stored Procedures
   > - `GetPilotFlightHistory` to fetch all flights flown by a specific pilot.
   > - `GetAirfieldUsageReport` to analyze airfield usage within a date range.
   > - `CheckPlaneMaintenanceStatus` to identify planes needing maintenance based on total flight hours or inactivity.
   > ```

### Simulating Flight Operations 

Improve **query performance** by creating a **non-clustered indexs** in the **Flight** table. This ensures that data is quickly accessible and reduces delays in data retrieval—just like optimizing takeoff efficiency.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Update the AviationDB.sql file. Create non-clustered indexes to optimize query performance for the Flight table. 
   > 
   > ## Indexes
   > - `DepartureTime` to speed up flight scheduling queries.
   > - `PilotId` to improve searches for a pilot's flight history.
   > - `PlaneId` and DepartureTime to optimize plane utilization queries.
   > ```

- Press `Enter` to submit the prompt.

> [!TIP]
> Always analyze execution plans to determine where indexes will have the most impact. Too many indexes can slow down inserts/updates!

### Visualize Entity Relationships

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Create a Mermaid Diagram named "EntityRelationshipDiagram.md" to visualize the relationships between Pilot, Plane, Flight, and Airfield tables.
   > ```

### Turbocharging Flight Scheduling

Generate **realistic flight records** with randomized **departure and arrival times**, linking them to **random pilots, planes, and airfields**. This provides a **diverse and dynamic dataset**, mirroring the unpredictable conditions of early aviation.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Update the AviationDB.sql file.  Create a stored procedure named GenerateFlightData that generates sample flight records with randomized departure and arrival times, linking them to random pilots, planes, and airfields. Ensure the data reflects realistic aviation scenarios.
   > ```

### Flight Readiness Check with Automated Testing 

Implement **Unit Testing** to **validate flight record operations**. This ensures the database **accurately processes flight data**, just as pre-flight checks ensure a **safe takeoff**.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Update the AviationDB.sql file. Create a new SQL script named TestFlightInsert.sql that sets up tSQLt to verify inserting and retrieving a Flight record works as expected. Include all necessary tSQLt setup, test class creation, and assertions to validate the operation.
   > ```

### Why is Testing so Important?
Ensuring data integrity and reliability in aviation systems is critical, just like pre-flight checks before takeoff. This tSQLt test provides:

- **`Confidence in Data Accuracy`** – Verifies that flight records are correctly inserted and retrieved, preventing data corruption or missing records.

- **`Automated Regression Testing`** – Ensures database changes don’t break existing functionality, keeping the system stable and reliable.

- **`Faster Debugging & Troubleshooting`** – Detects issues early in development, reducing manual testing efforts and speeding up deployments.

- **`Scalability & Maintainability`** – Establishes a testing framework that can be expanded for future database enhancements, ensuring continued data consistency.


---

## Demo 19: Gather Code Coverage for the backend project

Your task is to gather coverage reporting for the backend project and display the code coverage in the browser to see which parts of the code are not being tested.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
   >
   > ```prompt
   > - Generate a .NET code coverage report for test project `WrightBrothersApi.Tests` project using Cobertura format and ReportGenerator.
   > - Run tests with coverage enabled (dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura).
   > - Install ReportGenerator if it’s not already installed (dotnet tool install -g dotnet-reportgenerator-globaltool).
   > - Generate an HTML report in a coveragereport folder.
   > - Open the coveragereport/index.html file in the default browser.
   > ```

- Agent Mode understood your prompt and is being polite before taking action

## Demo 20: PromptCeption – Asking Copilot to Generate Prompts

- The practice of using GitHub Copilot to craft, refine, or generate prompts that improve future GitHub Copilot interactions. Code Smarter by Prompting the Prompter!

### **Finding cyclic dependencies**  

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
   >
   > ```prompt
   > Create a prompt that I send back to you to scan my codebase looking for top 3 high cycling and reduce my cyclic dependency.
   > ```

- Example output the prompt generated by Copilot.

```md
@workspace scan my codebase and identify the top 3 areas with high cyclomatic complexity. Provide suggestions to refactor and reduce cyclic dependencies in those areas. Ensure the suggestions align with modern C# practices, such as pattern matching, async/await, and proper error handling. If applicable, include code examples for refactoring.  Create a summary per file/finding on what to change and why.
```

- Use the prompt to analyze the codebase and make necessary changes to reduce cyclic dependencies.

### **Manual Pull Request Summaries**  

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
   >
   > ```prompt
   > Create an executive summary on everything I did in my #codebase in 1 paragraph and use bullets where needed.
   > ```

- Output the prompt generated by Copilot.

```md
Generate a PR-style summary of my local changes since the last git checkout: run git diff --name-status and git diff --numstat to gather filenames and line adds/removes, parse the output, and produce a Markdown summary with sections (Overview, Files Changed table, Highlights per file, and a Suggested PR title/body). Don’t stage or commit anything. Open the Markdown in VS Code for review and copy it to my clipboard.
```

### **GPT Model Comparision**  

```md
Create a Markdown file named model-comparison.md with a well-formatted table comparing the top 7 LLMs, including GPT-4.1 and GPT-5.
Columns: Model, Strengths, Limitations, Token Count, Best Use Case, Trained Date.
Add a one-sentence TL;DR for each model under Best Use Case.
Make the Markdown table visually appealing with proper headers, alignment, and spacing.
Save the file and open it in VS Code

```

- What strategy would you use to determine which model to use?

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
>
> ```prompt
> Create a strategy for me on how to manage my Premium Requests across these models.
> ```

### **Copilot Mode Comparision**  

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
>
> ```prompt
> Create a Markdown file named copilot-modes-comparison.md with a well-formatted table comparing GitHub Copilot Chat Ask Mode, Edits Mode, and Agent Mode.
> Columns: Mode, Primary Purpose, Strengths, Limitations, Best Use Case.
> Include a short TL;DR sentence for each mode in the Best Use Case column.
> Make the Markdown table visually appealing with proper headers, alignment, and spacing.
> Save the file and open it in VS Code.
> ```

### **Promptception**

### **Scenario**

You have a document that needs a quality check for grammar, duplicate content, and overall flow.
Instead of telling Copilot exactly what to do right away, you first **ask it to craft the best possible prompt** for that job — then you send that refined prompt back to Copilot.

This two-step method demonstrates how to use Copilot to **engineer better prompts** before executing them.

### **Ask Copilot to Write the Prompt**

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
>
> ```prompt
> Create a short, effective prompt for me to send back to you.  
> I want you to review a document to ensure it’s grammatically correct, free of duplicate content, and has a smooth, logical flow.
> ```

### **Copilot Generates the Refined Prompt**

- Output the prompt generated by Copilot.

```md
Review this document for grammar, duplicate content, and overall flow.  
Ensure it reads clearly, concisely, and logically.
```

You now paste the generated prompt back into Copilot to perform the actual review.

---

## Demo 21: GitHub Copilot Vision or “Image Understanding"

Mockup of polished image for webpage design.

<img width="500px" src=mock_DawnOfAviation_Sketch2.png>

### Describe it into a prompt

Start by turning pixels into a precise creative brief. This sets up DALL·E or a design pass.

> **DALL·E** is an AI system that can create realistic images and art from a description in natural language.

Lead-in prompt for Ask Mode:

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Edit Mode**
   >
   > ```prompt
   > Analyze the attached image and write a concise DALL·E prompt that recreates this UI. Include theme, nav items, hero composition, headline and subhead, the two CTAs, and a grid of 8 aircraft cards with names and years. Keep it 120–150 words, avoid brand names, focus on layout terms and visual style. Output only the prompt text.
   > ```

Optional, UI brief variant:

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
   >
   > ```prompt
   > Describe the layout of this page for an HTML and CSS implementation. Summarize nav, hero, CTA labels, card grid, spacing rhythm, and color accents in 8 bullets or fewer.
   > ```

### Extract structured data

Show that Vision can read card content and return clean data.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
   >
   > ```prompt
   > From this image, extract the aircraft cards as JSON. Fields: name, year, position (row, col). Return only a JSON array with 8 objects.
   > ```

### Tests from pixels

Turn what it saw into checks a team can run.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Ask Mode**
   >
   > ```prompt
   > Using only what is visible in the image, generate a Playwright test in TypeScript that expects:
   > - the page title contains "Dawn of Aviation"
   > - two CTA buttons "Learn More" and "Get Started" are visible
   > - exactly 8 cards exist
   > - each card has a name and a year that match the JSON I provide
   > Prefer getByRole and getByText. Add comments for selectors that may change.
   > ```

### Optional, “See it, fix it” in one pass

If you want one Agent step that produces code and bakes in accessibility, use a short persona.

   > <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
   >
   > ```prompt
   > You are a senior front-end engineer. You write tidy HTML and CSS, and call out assumptions briefly.
   > 
   > Task
   > From the attached image, generate a responsive HTML and CSS skeleton that matches the layout and style. Include semantic landmarks, alt text for images, visible focus styles, and color choices that meet WCAG AA.
   > 
   > Rules
   > - No external frameworks
   > - Single index.html and styles.css, print both files only
   > - Use CSS variables for key colors
   > - Keep the hero, two CTAs, and an 8-card grid
   > - Add TODO comments where content is inferred
   > 
   > Validation
   > List any assumptions and any secrets or assets I must provide. Then print the full code.
   > ```

---

## Demo 22: Build and Test Pipeline Automation

Time to automate everything! Let’s create a GitHub Actions workflow to build and test both the backend and frontend.

### Simple Version - Starting Point

To get started, we’ll use a detailed prompt to have Copilot generate a GitHub Actions workflow with two jobs: one for the backend and one for the frontend.

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
>
> ```prompt
> You are a senior CI engineer working to build a starting point for a CI/CD pipeline. You write clear GitHub Actions and explain assumptions briefly.
> 
> Task
> Create one workflow with two jobs, backend and frontend. Print files only, do not commit.
> 
> Rules
> - No secrets in YAML, add TODO placeholders
> - Folders: backend = wright-brothers-backend, frontend = wright-brothers-frontend
> - Triggers: push on main, and workflow_dispatch
> - Name: App CI, include concurrency to avoid overlapping runs
> 
> File to create
> - .github/workflows/app-ci.yml
> 
> Job 1, backend
> - runs-on: ubuntu-latest
> - steps: checkout, actions/setup-dotnet@v4
> - restore, build, test with coverage, upload coverage and test artifacts
> - dotnet publish -c Release
> - Optional deploy with azure/webapps-deploy@v3
>   Add TODO: set AZURE_WEBAPP_NAME and AZURE_WEBAPP_PUBLISH_PROFILE
> 
> Job 2, frontend
> - needs: backend, runs-on: ubuntu-latest
> - steps: checkout, actions/setup-node@v4
> - working-directory: wright-brothers-frontend
> - npm ci, run lint if present, run test if present, npm run build
> - upload build artifact
> - Optional deploy with Azure/static-web-apps-deploy@v1
>   Add TODO: set AZURE_STATIC_WEB_APPS_API_TOKEN
> 
> Nice to haves
> - Use actions/cache for NuGet and node_modules
> - Add a short job summary that links to artifacts
> 
> Validation
> - If lint or tests are missing, continue with build and note it
> - List required secrets to set
> - Always print the final YAML content of .github/workflows/app-ci.yml
> ```

### Advanced Version - Full CI/CD with Infrastructure as Code

Another option is to break the workflow into multiple jobs: one for infrastructure, one for the backend, one for the frontend, and one for the database. This allows each job to be more focused and easier to manage.

#### Infra as Code (Bicep)

First we start by scaffolding Azure IaC in `/iac` for `eastus` with module files + an orchestrating `main.bicep`.

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
>
> ```prompt
> Create `/iac` with these Bicep modules (all in `eastus`, names use `*-${uniqueString(resourceGroup().id)}`):
> 
> * `rg.bicep`, `appplan.bicep`, `appsvc.bicep`, `swa.bicep`, `sqlserver.bicep`, `sqldb.bicep`, `keyvault.bicep`
>   Add `/iac/main.bicep` wiring dependencies/outputs so the **SQL connection string** is produced and **stored in Key Vault**. Print the file tree and each module’s parameters/outputs. Don’t commit.
> ```

#### GitHub Actions skeleton + Infra deploy job

Next we create the `.github/workflows/ci-cd.yml` with an **Infra** job that deploys the Bicep.

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
>
> ```prompt
> Add `.github/workflows/ci-cd.yml` with:
> 
> * `on: push` (main)
> * `jobs.infra`: checkout, `azure/login`, and an ARM/Bicep deploy (resource group in `eastus`) using `/iac/main.bicep`.
>   Insert a clear placeholder comment: **`# TODO: Add azure-credentials secret here`**.
>   Output the YAML (no secrets), show the exact `az deployment` (or `azure/arm-deploy@v2`) command used, and keep room for later jobs (`backend`, `frontend`, `database`). Don’t commit.
> ```

#### Backend build/test/coverage + deploy to App Service

We will now extend the existing workflow by adding a **Backend** job.

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
>
> ```prompt
> Update `.github/workflows/ci-cd.yml` to add `jobs.backend` with `needs: infra`. Steps:
> 
> * Checkout, `actions/setup-dotnet@v4`
> * Run unit tests with coverage for the backend project in `wright-brothers-backend` (upload coverage artifact)
> * `dotnet publish` and deploy to App Service (use `azure/webapps-deploy`)
> * Fetch the **SQL connection string** from **Key Vault** (Managed Identity if available; otherwise via Key Vault action)
> * Keep region `eastus`, no secrets in YAML; rely on Key Vault + the credentials placeholder from the Infra job.
>   Print the updated YAML. Don’t commit.
> ```

#### Frontend build/test + SWA deploy, then DB schema deploy

We will now extend the workflow with **Frontend** and **Database** jobs.

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt - Agent Mode**
>
> ```prompt
> Update `.github/workflows/ci-cd.yml` with two jobs:
> 
> * `jobs.frontend` with `needs: infra`
> 
>   * Checkout, `actions/setup-node@v4`, install deps in `wright-brothers-frontend`
>   * Install Playwright, run linter + Playwright tests
>   * Build for prod and deploy to **Azure Static Web Apps** (`Azure/static-web-apps-deploy`)
> 
> * `jobs.database` with `needs: [infra, backend]`
> 
>   * Checkout, login to Azure
>   * Retrieve SQL connection string from **Key Vault**
>   * Apply `AviationDB.sql` to Azure SQL (e.g., `sqlcmd`/`SqlPackage`)
> ```

#### One Final CI/CD Workflow Merge

The final step is to merge the Infra, Backend, Frontend, and Database jobs created in previous steps into a single `.github/workflows/ci-cd.yml` with the correct `needs` dependencies, keeping all Azure resources in `eastus`, ensuring all secrets are sourced from **Key Vault**, and preserving the `# TODO: Add azure-credentials secret here` placeholder. Print the complete YAML and the final job order.

> <img width="13px" src="https://github.com/user-attachments/assets/98fd5d2e-ea29-4a4a-9212-c7050e177a69" /> **Prompt**
>
> ```prompt
> Merge the Infra, Backend, Frontend, and Database jobs created in previous steps into a single `.github/workflows/ci-cd.yml` with the correct `needs` dependencies, keeping all Azure resources in `eastus`, ensuring all secrets are sourced from Key Vault, and preserving the `# TODO: Add azure-credentials secret here` placeholder. Print the complete YAML and the final job order.
> ```

---

## 🎉 All done!

---
