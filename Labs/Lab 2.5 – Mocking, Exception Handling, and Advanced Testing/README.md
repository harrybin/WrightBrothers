## Lab 2.5 – Mocking, Exception Handling, and Advanced Testing

This lab exercise explores how GitHub Copilot can assist in building robust unit tests, including scenarios for mocking dependencies, handling exceptions, and covering edge cases. You’ll use prompts and hands-on code updates to strengthen your backend’s reliability.

## Prerequisites
- The prerequisites steps must be completed, see [Labs Prerequisites](../Lab%201.1%20-%20Pre-Flight%20Checklist/README.md)

## Estimated time to complete

- 10 minutes.

## Objective
- Learn to leverage Copilot to generate, refine, and expand unit tests with mocking and exception handling, making your codebase more resilient and maintainable.
  - Step 1: Exploring Mocking in Unit Tests
  - Step 2: Adding a Negative Test for an Exception Scenario
  - Step 3: Writing a Unit Test for Exception Handling
  - Step 4: Advanced Mocking (Optional)
  - Step 5: Run and Review All Tests

---

## Step 1: Exploring Mocking in Unit Tests

Open `PlanesControllerTests.cs`.

Notice the use of a mock logger via NSubstitute in the test constructor:
```csharp
_logger = Substitute.For<ILogger<PlanesController>>();
_planesController = new PlanesController(_logger);
```

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:

```
Explain why we use a mock logger in PlanesControllerTests. Can Copilot show how to mock other dependencies, like repositories, using Moq?
```

Ask Copilot to generate a basic test that mocks a dependency and explains the pattern.

---

## Step 2: Adding a Negative Test for an Exception Scenario

- Open `PlanesController.cs` file.

- Highlight the `GetById` or `Post` method.

- Press `Ctrl+I` to open the Inline Editor.

- Add a line to throw an exception if a specific condition is met (for the exercise).

- In **GitHub Copilot Chat**.

- Type the following prompt:

```
Add logic in PlanesController.GetById to throw an InvalidOperationException if id == -1.
```

- Accept the suggestion and save your changes.

---

## Step 3: Writing a Unit Test for Exception Handling

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:

```
Write a unit test in PlanesControllerTests.cs that verifies GetById(-1) returns a 500 Internal Server Error if an exception is thrown.
```

- Accept the suggestion, review the generated test.

- Insert it into bottom of test file `PlanesControllerTests.cs`.

- Review Copilot’s approach. Exception handling is important in controllers to ensure that errors are caught and handled gracefully.

---

## Optional: Bulk Test Generation with Copilot Edits or Agent Mode

Ready to take your unit testing further?
Try one of these advanced options:

### Using Copilot Edits

- Open **GitHub Copilot Edits**.

- Click `+` to clear prompt history.

* Add `PlanesControllerTests.cs` to the working set.

- Type the following prompt:

  ```
  Generate all positive and negative test cases for the controllers, including tests for exception scenarios, and organize them with clear comments.
  ```

* Review and Accept the proposed tests.

### Using Agent Mode (for advanced users)

- Open **GitHub Agent Mode**.

- Click `+` to clear prompt history.

- Type the following prompt:

  ```
  Generate comprehensive unit tests for all controllers, covering edge cases and exception handling. Highlight any files changed.
  ```

- Let Agent Mode automate these additions, then review and run the new tests.

> **Why Try This?**
> For larger projects, Copilot Edits and Agent Mode can generate or update a wide set of tests at once, helping you spot gaps and avoid repetitive manual work.

---

## Step 4: Advanced Mocking (Optional)

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:

```
Show how to use Moq to mock a repository dependency for PlanesController and verify that Post adds a plane using the repository.
```

- GitHub Copilot will generate an example, reviewing the style and structure.

---

## Step 5: Run and Review All Tests

- Run your unit tests again.

* Did Copilot generate realistic negative and exception test cases?
* How does mocking help in writing isolated and repeatable unit tests?

### Congratulations you've made it to the end! &#9992; &#9992; &#9992;

#### And with that, you've now concluded this module. We hope you enjoyed it! &#x1F60A;