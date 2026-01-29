# ✈️ GitHub Copilot Agent Mode: Wright Brothers Guided Demos

⏱️ **Estimated Duration: 30 minutes**

---

Welcome to the GitHub Copilot Agent Mode guided demos for the Wright Brothers app! This collection of demos showcases real-world automation across APIs, UIs, and data workflows.

This markdown file walks through a series of GitHub Copilot demos using **Agent Mode only**. Each section builds on the previous one, helping you showcase progressively advanced capabilities in a live demo or hands-on lab.

---

# Wright Brothers Backend Demos

## Demo 1: Plane API Endpoints

### Scenario

We want to enhance an existing `PlanesController.cs` to support more backend operations such as querying by year, updating, and deleting planes.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Add new endpoints to PlanesController.cs that allow querying planes by year, updating existing planes, and deleting planes. Make sure to follow existing controller structure.
```

---

## Demo 2: Debugging a Backend Bug

### Demo /flights/:id Endpoint Bug

- cd to the backend project folder, `wright-brothers-backend\WrightBrothersApi`
- Run the backend project using `dotnet run`
- Open a browser and navigate to `http://localhost:1903/flights/2`
- Observe that the flight with ID `3` is returned instead of `2`

### Scenario

We found a bug in the API where requesting a specific flight by ID returns the wrong result.

### Option 1

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
There's a bug in the FlightsController. When I go to /flights/2, the app returns the wrong flight — it shows the flight with ID 3 instead of 2.

Please investigate and fix the bug so that the correct flight is returned when requesting by ID.
- Make any updates necessary to resolve this.
- Run the backend project to verify the fix.
  - Hint: After starting the backend, navigate to `http://localhost:1903/flights/2` to test the fix.
```

### Option 2

> **Delegate to Coding Agent** - Select model **GPT-4.1**

- View from repo on GitHub.com, **[WIP] Bug Fix in FlightsController for Incorrect Flight ID Retrieval** 

### Option 3

> **Create Issue and assign to Coding Agent** - Select model **GPT-4.1**

  When using GitHub Copilot to create issues, you can leverage the following template to report bugs or request enhancements.

  **Title:**
  ```
  Bug: Incorrect flight returned from `/flights/:id` endpoint
  ```

  ```
  **Steps to Reproduce:**

  1. Run the backend project locally
  2. Navigate to `http://localhost:1903/flights/2`
  3. Observe that it incorrectly returns flight with ID `3` instead of `2`

  **💡 Expected Behavior:**
  It should return the flight with ID `2`

  **Request**
  Please investigate and fix this bug. Make all necessary code updates so the correct flight is returned when requesting by ID.
  ```

---

## Demo 3: Code Coverage in the Browser

### Scenario

Let’s generate a visual code coverage report for backend unit tests.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Show me code the HTML coverage report for my backend project unit tests and display in the browser.
- Print the URL so I can click to view the demo.
```

---

## Demo 4: Writing Unit Tests for GetById

### Scenario

You already have a method `GetById` in `PlanesController.cs`, but no tests.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Generate unit tests for the GetById method in PlanesController.cs, including all edge cases. Append the tests to the PlanesControllerTests.cs file using the existing test structure and naming conventions.
- Run all the tests to ensure they pass.
```

---

## Demo 5: Complete Unit Test Coverage - Existing Test Controller

### Scenario

We now want to ensure all methods in `PlanesController` are covered by unit tests.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Add missing unit tests for the PlanesController class and append them to the PlanesControllerTests.cs file.
- Ensure that the tests cover all possible scenarios, including edge cases.
- Run all the tests to ensure they pass.
- If any tests fail, debug the issues, fix them, and re-run the tests.
```

---

## Demo 6: Generate Unit Tests - New Test Controller

### Scenario

You now want to build tests for the `FlightsController`, similar to your `PlanesControllerTests`.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Create a new test class for the FlightsController.cs based on the style of PlanesControllerTests.cs.
- Ensure that the tests cover all possible scenarios, including edge cases.
- Run all the tests to ensure they pass.
- If any tests fail, debug the issues, fix them, and re-run the tests.
```

---

## Demo 6.6 – Generating the FlightTrial Model and Controller from Excel Data

We have this data that's been managed manually in Excel and will be migrated to the database. We need an API to access and manipulate the data programmatically via a new endpoint.

Use **GitHub Copilot Agent** mode to generate a new model and controller based on the image below.

1. Right-click the image below and choose **Copy Image**:

   <img src="../Images/Screenshot-FlightTrialsExcelTestData.png" width="800">

2. Paste the image directly into the Copilot Chat window.

3. Paste the prompt directly below the image:

   ```
    Create the C# model called `FlightTrial` for this data and place it into the existing models folder next to #file:Plane.cs.  
    - Create the controller called `FlightTrialsController` and place it into the existing controllers folder next to #file:PlanesController.cs  
    Include all standard API CRUD operations.  
    - Build out the list of FlightTrials in the controller using the data from the screenshot.  
    - Ensure to add error handling for bad or missing data.  
    - Add validation attributes to the `FlightTrial` model:  
        - Use [Required] for all non-nullable fields  
        - Use [Range] for numeric values like `DistanceKm` and `DurationMinutes`  
        - Use [StringLength] or [MaxLength] where appropriate for `Notes` and `Outcome`  
        - Ensure that the controller returns BadRequest when the model state is invalid
   ```

4. Click **Keep** and confirm the files were added to the right folders.

> [!NOTE]
> Agent Mode allows Copilot to work across multiple files and create a complete solution. You’re giving it structured instructions and real data to work from, just like an engineer importing a legacy system into a modern API.

---
## Demo 6.7 – Creating and Running Unit Tests for FlightTrialsController

Now that you’ve created the new API, it’s time to confirm it works correctly by generating and running unit tests.

1. Use **GitHub Copilot Agent** mode to generate the unit tests.

1. Paste the following prompt:

   ```
    Create a new test controller called `FlightTrialsControllerTests.cs` and place it next to #file:PlanesControllerTests.cs.  
    - Create unit tests for everything in the #file:FlightTrialsController.cs.  
    - Ensure to handle both negative and positive test scenarios.  
    - Run all the unit tests using dotnet test and show me which ones pass or fail.  
    - If any tests fail, fix them in #file:FlightTrialsControllerTests.cs and rerun the tests until all tests pass.
   ```

1. If you're asked to build or run tests, click **Continue**.

Copilot will generate the tests, run them, fix them if they fail, and show the results. Most should pass, for example:

   ```sh
   Test summary: total: 11, failed: 0, succeeded: 11, skipped: 0
   ```

> [!NOTE]
> You’re now leveraging Agent Mode’s full power: multi-file editing, intelligent file placement, code generation, test execution, and iterative improvements—all in one chat window.

---

## Demo 7: Code Coverage HTML Enhancements

### Scenario

You’re already using ReportGenerator and want to refresh and beautify the HTML output.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Use the existing ReportGenerator tool to recreate the code coverage HTML report.
- Make the HTML coverage report more visually appealing. 
- Print the URL so I can click to view the demo.
```

---

## Demo 8: Refactor and Parse Flight Logs

### Demo /flights/:id Endpoint FlightLogSignature

- cd to the backend project folder, `wright-brothers-backend\WrightBrothersApi`
- Run the backend project using `dotnet run`
- Open a browser and navigate to `http://localhost:1903/flights/2`
- Observe the `FlightLogSignature` value in the response
- Stop the backend project by pressing `Ctrl + C`

### Scenario

This property is used in the FlightsController and assigned a hard to read value, i.e. FlightLogSignature = "171203-DEP-ARR-WB001",
Let's refactor this to be more readable and parse the value to separate the flight date, departure, arrival, and flight number.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Create a new c# model for a FlightLogSignature property.

## Example
17121903-DEP-ARR-WB001

## Example Details
17th of December 1903
Departure from Kitty Hawk, NC
Arrival at Manteo, NC
Flight number WB001

## Technical Requirements
- Create a record type named FlightLog in a new file called FlightLog.cs and save it to the models folder alongside of Flight model.
- Implement a Parse method in the FlightLog record type to parse a FlightLogSignature.
- Ensure the FlightLogSignature consists of exactly four parts separated by -. The format should be:
    - {Date}{DEP}{ARR}{FlightNumber}
    - Example: 17121903-DEP-ARR-WB001
- Parse the Date as DateTime (format: ddMMyyyy).
- Include necessary using statements at the top of the file.
- Use a try-catch block inside Parse to catch and handle any parsing errors.
- Add a read-only FlightLog property (getter only) to the Flight model.
- Include explanations as comments.

Build and run the backend project to verify the changes.
```

- Run the backend project using `dotnet run`
- Open a browser and navigate to `http://localhost:1903/flights/2`
- Observe the `FlightLogSignature` value in the response
- Stop the backend project by pressing `Ctrl + C`

---

## Step 9: Ascending to the Clouds – Creating Controllers

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

# Wright Brothers Frontend Demos

## Demo 10: Improve Home Page Layout

### Getting Started

Before using GitHub Copilot Agent Mode run the frontend and backend projects locally.

### Step 1: Change to the Frontend Folder
```plaintext
cd to wright-brothers-frontend
npm install
npm run frontend
```

### Step 2: Run the Frontend Project
In the terminal, run the following commands:
```
npm run frontend
```

### Step 3: Open the Frontend in the Browser
Navigate to `http://localhost:5173` in your browser to view the frontend.

### Scenario

You want to enhance the homepage banner readability and switch from a list to a responsive grid layout for planes. Also, the banner is missing call to action buttons to notify the crew.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
I'd like to improve the homepage layout to make it more readable and modern.

Instructions:
- Update the banner subtitle to be easier to read
- Center the title and subtitle inside the banner
- Change the plane list to a responsive grid layout that works well on all screen sizes

Updates:
The banner is missing call to action buttons to notify the crew.
- Create two call to action buttons in the banner.
  - Place them below the subtitle and center them.
  - The first button is primary and should have the text "Learn More" and the second button is secondary should have the text "Get Started".
  - The buttons should match the design of the banner.
  - Make sure the color of text is easy to read to fit the existing color palette while still improving readability.
```

---

## Demo 11: Build Add Plane Button and Modal Form

### Scenario

Make it easy for users to add a new plane directly from the homepage by clicking an “Add Plane” button that opens a modal form. After filling out the form, users are returned to the homepage with their new plane added to the list.

### Option 1

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Build Add Plane Button and Modal Form

You are working on the Wright Brothers demo app.
Create a full “Add Plane” feature, combining a button on the homepage with a modal form.

### Instructions

1. **Create a reusable button component:**

   * Name: `AddPlaneButton.tsx` in `src/components`
   * Button text: `Add Plane`
   * Add a plus icon to the left of the text, using `@heroicons/react/24/solid`
   * Match the style of other buttons in `PlaneList.tsx`

2. **Add the button to the homepage:**

   * Import and place the new `AddPlaneButton` just below the `Banner` in `HomePage.tsx`, inside the `PageContent` component.

3. **On click, open a modal form (not a separate page):**

   * Build a modal form component for adding a new plane, matching the `Plane` model in `Plane.cs`.
   * Use **Formik** for form state and **Yup** for validation.
   * Include all fields from `Plane.cs` (with label and ID for each).
   * Use Tailwind CSS to match the look and feel of `PlaneList.tsx`.
   * On successful submit (POST to `http://localhost:1903/planes`), close the modal and redirect (or reload) to the home page.

4. **Accessibility and usability:**

   * Modal should be accessible via keyboard and screen readers.
   * Form must have proper ARIA labels.
```

### Option 2

> **Delegate to Coding Agent** - Select model **GPT-4.1**

- View from repo on GitHub.com, **[WIP] Build Add Plane Button and Modal Form** 

### Option 3

> **Create Issue and assign to Coding Agent** - Select model **GPT-4.1**

When using GitHub Copilot to create issues, you can leverage the following template to report bugs or request enhancements.

**Title:**
```
Feature: Add modal form for creating a new Plane
```

```
**Steps to Reproduce:**

1. Create a new page at `/add-plane` in `AddPlanePage.tsx`
2. Build a POST form that submits to `http://localhost:1903/planes`
3. Use the existing `Plane` model (from `Plane.cs`)
4. Form should:

   * Use **Formik** for form handling
   * Use **Yup** for validation
   * Include **all fields from Plane.cs** (don’t skip any)
   * Use **Tailwind CSS** for styling to match `PlaneList.tsx`
   * Include proper labels and IDs
   * Redirect to home page on success
   * Be accessible at `/add-plane`
   * Appear as a **modal**, not a full page

**Copilot Task:**
Please build the full modal form based on the specs above.
```

---

## Demo 12: View / Edit / Delete Planes

### Scenario

You want users to be able to view, edit, and delete plane details in a modal-based UI.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```
Add a new feature to the frontend application that allows users to view details, edit details, and delete a plane from the list of planes in the application using a modal form.
```

---

# Wright Brothers Automation Demos

## Demo 13: Blueprinting the Aviation Database

#### ✅ **Step 1 – Create the SQL File and Use the Database**

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

```bash
Create a SQL Server DDL file named `AviationDB.sql` that defines a basic schema for a Wright Brothers aviation database.

## Tables
- Pilot
- Plane
- Flight
- Airfield

## DDL Statements
- Ensure proper data types (e.g., INT, VARCHAR, DATETIME).
```

---

#### ✅ **Step 2 – Define Relationships, Indexes, and Stored Procedures**

```bash
Refactor the AviationDB.sql file to ensure a proper relational structure while maintaining clarity and efficiency.

## Relationships
- Ensure proper One-to-Many relationships between tables.
- A Pilot can fly multiple Planes over time.
- A Plane can be assigned to multiple Airfields over time.
- A Plane can have multiple Flights recorded.
- An Airfield can host multiple Planes over time.

## Details
- Define each table with primary keys, foreign keys, and constraints.
- Include FOREIGN KEY constraints for relationships.

Add non-clustered indexes to optimize query performance for the Flight table.:
- `DepartureTime` to speed up flight scheduling queries.
- `PilotId` to improve searches for a pilots flight history.
- `PlaneId` and DepartureTime to optimize plane utilization queries.

Add these stored procedures:
- `GetPilotFlightHistory` to fetch all flights flown by a specific pilot.
- `GetAirfieldUsageReport` to analyze airfield usage within a date range.
- `CheckPlaneMaintenanceStatus` to identify planes needing maintenance based on total flight hours or inactivity.```
```

---

#### ✅ **Step 3 – Insert Sample Data**

```bash
Refactor the AviationDB.sql to generate realistic test data for all tables in AviationDB.sql

## Details
- Data should be historically accurate, reflecting Wright Brothers aviation history (1903-1910).
- Use INSERT statements to create a diverse and representative dataset with 3 records per table for historical accuracy.
```

### Bonus Round 1: **Turbocharging Flight Scheduling with Test Data**

**Scenario:**

You want to generate test data for the Flight table to simulate a busy day at the Wright Brothers airfield.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

```bash
Refactor the AviationDB.sql to create a stored procedure named GenerateFlightData.

## Details
- Generate sample flight records with randomized realistic departure and arrival times.
- Link each flight to random existing pilots, planes, and airfields.
- Ensure arrival time is after departure time.
- Reflect realistic Wright Brothers era operational scenarios (simulate a busy day).
```

### Bonus Round 2: **Visualize Entity Relationships**

**Scenario:**

You want to generate a visual representation of the relationships between the Pilot, Plane, Flight, and Airfield tables.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

```bash
Create a Mermaid Diagram named "EntityRelationshipDiagram.md".

## Details
- Visualize Pilot, Plane, Flight, Airfield entities.
- Show One-to-Many relationships clearly.
- Indicate primary and foreign key fields.
- Highlight key constraints relevant to the schema.
- Keep diagram concise and historically contextual.
```

---

## Demo 14: Build and Test Pipeline Automation

### Scenario

Time to automate everything! Let’s create a GitHub Actions workflow to build and test both the backend and frontend.

### Option 1

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

**Prompt:**

```bash
Create a complete GitHub Actions build-deploy pipeline for the Wright Brothers Aviation app:

1. Provision Azure infrastructure in the eastus region using Bicep IaC:

  - For each Azure service, create a separate Bicep file in the /iac directory:
     * Resource Group: `rg-WrightBrothers`
     * Web App Plan: `appplan-${uniqueString(resourceGroup().id)}`
     * App Service: `appsvc-${uniqueString(resourceGroup().id)}`
     * Static Web App: `swa-${uniqueString(resourceGroup().id)}`
     * SQL Server: `sqlsrv-${uniqueString(resourceGroup().id)}`
     * SQL Database: `sqldb-${uniqueString(resourceGroup().id)}`
     * Key Vault: `kv-${uniqueString(resourceGroup().id)}`
  - Create a `main.bicep` file to orchestrate these modules and handle dependencies/outputs between them (for example, passing the SQL connection string to Key Vault).
  - All resources must be provisioned in `eastus`.

2. Create a Key Vault (`kv-${uniqueString(resourceGroup().id)}`) and store the Azure SQL Database connection string as a secret.
  - Backend deployment must securely access the connection string from Key Vault (using Managed Identity if possible).

3. Pipeline Stages:
  - Backend: Install dependencies, run unit tests, collect/upload code coverage, build, deploy to App Service.
    - Use the folder structure from `wright-brothers-backend` to identify the backend project.
  - Frontend: Install dependencies, install Playwright, run linter, run Playwright tests, build for production, deploy to Static Web App.
    - Use the folder structure from `wright-brothers-frontend` to identify the frontend project.
  - Database: Deploy schema and data to Azure SQL Database using the `AviationDB.sql` file.

4. Pipeline Order: Infrastructure (Bicep/IaC) → Backend/Frontend (build/test/deploy) → Database
5. Secrets: All secrets (including SQL connection strings) must be stored in Key Vault and referenced securely in the workflow
6. Region: All Azure resources and deployments are to be done in `eastus`
7. Add a placeholder in the pipeline for me to insert my Azure credentials (comment or input section):**
  - # TODO: Add azure-credentials secret here
```

### Option 2

> **Delegate to Coding Agent** - Select model **GPT-4.1**

- View from repo on GitHub.com, **[WIP] Build and Test Pipeline Automation** 

### Option 3

> **Create Issue and assign to Coding Agent** - Select model **GPT-4.1**

When using GitHub Copilot to create issues, you can leverage this template to request a fully automated CI/CD pipeline and Azure resource provisioning for your project.

Paste the following title as `Add a title`

**Title**
```
Feature: Create GitHub Actions CI/CD pipeline for Wright Brothers backend, frontend, and Azure SQL database
```

Paste the following description as `Add a description`

**Add a description**
```
**Scenario:**

The repo contains both backend (.NET) and frontend (JavaScript/Playwright) projects, along with an `AviationDB.sql` file for database initialization.

Request a fully automated CI/CD pipeline and modular Azure resource provisioning for the Wright Brothers Aviation application.

The solution must use GitHub Actions for build and deployment, and Bicep Infrastructure as Code (IaC) to provision all Azure resources. Each Azure service should have its own Bicep file (e.g., `appplan.bicep`, `appsvc.bicep`, `swa.bicep`, `sqlsrv.bicep`, `sqldb.bicep`, `kv.bicep`), all located in the `/iac` directory. A `main.bicep` file must orchestrate these modules and handle dependencies/outputs between them (for example, passing the SQL connection string to Key Vault).

**Key Requirements:**
- All resources must be deployed to the `eastus` Azure region.
- Resource names must use the following patterns (with uniqueness via `uniqueString(resourceGroup().id)`):
    - Resource Group: `rg-WrightBrothers`
    - Web App Plan: `appplan-${uniqueString(resourceGroup().id)}`
    - App Service: `appsvc-${uniqueString(resourceGroup().id)}`
    - Static Web App: `swa-${uniqueString(resourceGroup().id)}`
    - SQL Server: `sqlsrv-${uniqueString(resourceGroup().id)}`
    - SQL Database: `sqldb-${uniqueString(resourceGroup().id)}`
    - Key Vault: `kv-${uniqueString(resourceGroup().id)}`
- The Key Vault must store the Azure SQL Database connection string as a secret, for secure access by the backend.
- The GitHub Actions workflow should:
    1. Provision infrastructure (via the modular Bicep files, orchestrated by `main.bicep`)
    2. Build, test, and deploy the backend to App Service
    3. Build, test, and deploy the frontend to Static Web App
    4. Deploy the `AviationDB.sql` file to Azure SQL Database
- All secrets must be securely managed using Azure Key Vault.
- The region is hard-coded to `eastus`.
- The workflow must include a placeholder for Azure credentials, e.g.:
  - # TODO: Add azure-credentials secret here

The solution must be robust, modular, and suitable for repeatable CI/CD execution.
```

---

## 🎉 All done!
