## Lab 2.4 – Building and Testing for Robustness

In this lab, you will use GitHub Copilot Chat and Copilot Edits to create and improve unit test coverage for your backend API. You’ll add both positive and negative test cases, validate model data using annotations, and practice using Copilot prompts to streamline your testing workflow.

## Prerequisites
- The prerequisites steps must be completed, see [Labs Prerequisites](../Lab%201.1%20-%20Pre-Flight%20Checklist/README.md)

## Estimated time to complete

- 10 minutes.

## Objective
- Build confidence in using Copilot to quickly add tests, enforce model validation, and improve code reliability with practical, real-world scenarios.
    - Step 1: Understanding Model Validation with Copilot Chat
    - Step 2: Adding Data Annotations
    - Step 3: Generating Positive Unit Test with Copilot Chat
    - Step 4: Generating Negative Unit Tests for Validation Errors
    - Step 5: Validating and Running Tests

---

## Step 1: Understanding Model Validation with Copilot Chat

Open `Plane.cs` and review the model. Notice that there are currently no data annotation attributes.

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:

```
@workspace What kind of validation can I add to the Plane model to prevent missing or invalid data?
```

Observe Copilot’s suggestions (e.g., `[Required]`, `[Range]`, `[StringLength]`).

---

## Step 2: Adding Data Annotations

In `Plane.cs`, add some basic data annotations for validation, such as:

- `[Required]` for `Name`
- `[Range(1900, 2025)]` for `Year`
- `[StringLength(100)]` for `Description`

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:

```
Add \[Required] to Name, \[Range(1900, 2025)] to Year, and \[StringLength(100)] to Description in the Plane class.
```

Accept Copilot’s suggestions or adjust as needed.

---

## Step 3: Generating Positive Unit Test with Copilot Chat

Open `PlanesControllerTests.cs`.

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:

```
@workspace Generate a unit test for PlanesController.Post that verifies a valid Plane is accepted and added.
```

Accept the suggestion, review the generated test, and insert it into bottom of test file `PlanesControllerTests.cs`.

---

## Step 4: Generating Negative Unit Tests for Validation Errors

Now prompt Copilot to create tests that check for invalid data.

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:

```
Create unit tests for PlanesController.Post that check when:

* Name is missing (null or empty)
* Year is out of range (e.g., 1800)
* Description is too long
```

Insert the suggested tests, reviewing Copilot’s reasoning and comments.

---

## Step 5: Validating and Running Tests

Run your tests in the terminal:
```
dotnet test WrightBrothersApi/WrightBrothersApi.Tests/WrightBrothersApi.Tests.csproj
```

If any tests fail due to missing validation, ask Copilot:

- Open **GitHub Copilot Chat**.

- Click `+` to clear prompt history.

- Type the following prompt:
```
How do I make the Post action return BadRequest for invalid models?
```

Follow Copilot’s guidance to update the controller so that it uses model validation (such as `if (!ModelState.IsValid) return BadRequest(ModelState);`).

Rerun your tests and confirm that both positive and negative scenarios behave as expected.

## Optional: Transition to Copilot Edits for Bulk Changes

Want to speed things up, or apply changes across multiple files at once?

Now that you’ve used Copilot Chat for focused, step-by-step improvements, let’s explore how Copilot Edits can make larger or repetitive changes even faster!

### Using Copilot Edits

- Open **GitHub Copilot Edits**.

- Click `+` to clear prompt history.

- Add `Plane.cs` and `PlanesController.cs` to your working set.

- Type the following prompt:

```
Add or update data annotations for validation on all properties in Plane.cs, and ensure the controller enforces model validation.
```

- Review Copilot’s suggested changes. Edits allows you to preview, accept, or adjust all changes at once—great for keeping code consistent across multiple files.

- Click `Apply` to update your files with the new annotations and validation checks.

### Using Agent Mode (for advanced users)

- Type the following prompt:

```
Apply data annotations to all models for validation and update controllers to return BadRequest for invalid models. List any files changed.
```

- Let Agent Mode automate these updates, then review the changes before committing.

> [TIP!]  
> **Why Try This?** Copilot Edits and Agent Mode can handle bulk or repetitive tasks, giving you safe, reviewable updates with just one prompt.

### Congratulations you've made it to the end! &#9992; &#9992; &#9992;

#### And with that, you've now concluded this module. We hope you enjoyed it! &#x1F60A;