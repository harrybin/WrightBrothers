# GitHub MCP Server Demo Scenarios

A collection of practical Agent Mode prompts that demonstrate real interactions with your GitHub repository using the GitHub MCP server.
Each example includes a **lead-in**, the **prompt**, and a **sign-post** explaining what just happened.

---

## **1. Issue-Driven Development**

Start with a real-world example of creating a new feature request directly from chat.

**Prompt:**

```
@github create issue "Add a feature to list all planes in the Wright Brothers API."
```


This creates a new GitHub Issue in your repo, pre-filled with title, body, and metadata, all without leaving VS Code.

---

### **Step 1: Draft the user story, requirements, and acceptance criteria**

**Prompt:**

```
I want a new API feature in the Wright Brothers Flights API.

Write a user story, detailed requirements, and acceptance criteria for this feature:

"As a dispatcher, I want an endpoint that returns all planes with a top speed greater than a specified value, so I can quickly identify our fastest aircraft."

Return the result in Markdown with sections: 
- User Story
- Requirements
- Acceptance Criteria
```


This gives you a well-structured story with clear requirements and testable acceptance criteria, ready to drop straight into a GitHub Issue.

---

### **Step 2: Create the issue using the GitHub MCP server**

**Prompt:**

```
@github create issue "Add endpoint to list planes by minimum top speed" using the User Story, Requirements, and Acceptance Criteria from your last response as the issue body. 

Apply labels: enhancement, backend, api.
Assign it to me and set the milestone to the next release.
```


This creates a fully formed issue in your repo, with labels, ownership, and milestones, all driven from natural language.

---

### **Step 3: Example Issue Body**

**Prompt:**

```
#### **User Story**
As a dispatcher,
I want an API endpoint that returns all planes with a top speed greater than a specified value,
so I can quickly identify our fastest aircraft for time-sensitive routes.

#### **Requirements**

1. **New endpoint**

   * Add a new GET endpoint, for example:
     `GET /api/planes/by-top-speed` or `GET /api/planes?minTopSpeedMph={value}`
   * Follow existing API naming conventions.

2. **Input parameters**

   * Required query parameter: `minTopSpeedMph` (integer).
   * Return `400 Bad Request` for missing or invalid values.

3. **Filtering logic**

   * Return only planes where `TopSpeedMph >= minTopSpeedMph`.
   * Return `200 OK` with an empty array if no matches are found.

4. **Response shape**

   * Include:
     `id`, `name`, `model`, `manufacturer`, `topSpeedMph`, `isActive`.
   * Sort descending by `topSpeedMph` by default.

5. **Error handling**

   * Follow existing error format with `code` and `message`.

6. **Testing**

   * Add unit tests for:

     * Valid requests with results
     * No matches
     * Missing/invalid parameters

7. **Documentation**

   * Update Swagger/OpenAPI and README examples.

#### **Acceptance Criteria**

1. **Happy path**

   * `GET /api/planes?minTopSpeedMph=200` returns only planes ≥ 200 mph in descending order.

2. **No matching planes**

   * Returns `200 OK` with an empty array.

3. **Missing parameter**

   * Returns `400 Bad Request` with clear validation message.

4. **Invalid parameter**

   * Returns `400 Bad Request` explaining `minTopSpeedMph` must be a number.

5. **Sorting**

   * Supports optional `sortOrder=asc|desc`.

6. **Docs updated**

   * Endpoint visible in API docs with example request and response.

```

---

## **2. Assigning an Issue to the Coding Agent**

Show how an issue becomes an actionable task.

**Prompt:**

```
Assign this issue to the Coding Agent and start a new branch called feature/list-planes
```


Copilot automatically links the issue, creates a branch, and gets ready to implement the feature.

---

## **3. Implementing a Code Change**

Demonstrate Copilot writing and committing code.

**Prompt:**

```
In PlanesController.cs, add an endpoint to return all planes with a top speed over 200 mph.
```


The Coding Agent edits, commits, and prepares a pull request, all under developer supervision.

---

## **4. Summarizing the Pull Request**

Show how Copilot helps during reviews.

**Prompt:**

```
Summarize the pull request and list files changed.
```


Copilot provides a quick summary and highlights what changed, helping reviewers stay efficient.

---

## **5. Repository Exploration**

Let the audience see how conversational repo queries work.

**Prompt:**

```
List all controllers in this repository.
```


This gives you an instant inventory of your API structure, without searching through folders manually.

---

## **6. CI/CD Workflow Automation**

Demonstrate creating a GitHub Actions workflow.

**Prompt:**

```
Create a GitHub Actions workflow that runs all unit tests on push to main.
```


The Agent writes a new YAML workflow file and commits it directly to your repo.

---

## **7. Security and Code Scanning**

Show the security intelligence of GitHub MCP.

**Prompt:**

```
List all open CodeQL alerts in this repository.
```


Copilot retrieves the latest CodeQL results and can even suggest remediations inline.

---

## **8. Documentation Support**

Wrap up by showing Copilot’s ability to help with repo docs.

**Prompt:**

```
Generate a summary of this repository for the README.
```


Copilot scans your repo and writes a clear overview you can paste into your README file.

---

## **9. Branch and Commit Management**

Show branch awareness and history review.

**Prompt:**

```
List all branches with active development and summarize recent commits for feature/add-flight-routes.
```


Copilot uses the GitHub MCP integration to surface branch names and summarize commit history directly in chat.

---

## Example Prompts for Reviewing Security Alerts

> Trainer, replace URL with your demo repository URL as needed.

### 1. Show Open Security Alerts by Type

```
Show me the top 5 open security alerts in https://github.com/Technical-Bootcamp/pagelsr-ghas-bootcamp, grouped by alert type (e.g., secret scanning, code scanning, Dependabot).
```

### 2. List All Secret Scanning Alerts

```
List me the top 10 secret scanning alerts in https://github.com/Technical-Bootcamp/pagelsr-ghas-bootcamp, ordered by Secret type including the file and line number where each secret was found.
```

### 3. Review Pull Requests with Open Security Alerts

```
Show all open pull requests in https://github.com/Technical-Bootcamp/pagelsr-ghas-bootcamp that have unresolved security alerts. Include the PR title, author, and alert type.
```

### 4. Summary of Code Scanning Alerts in PRs

```
Summarize all code scanning alerts found in open pull requests for https://github.com/Technical-Bootcamp/pagelsr-ghas-bootcamp. Group by alert severity and provide direct links to the affected PRs.
```

### 5. List PRs by Most Recent Security Alert Activity

```
List pull requests in https://github.com/Technical-Bootcamp/pagelsr-ghas-bootcamp, sorted by the most recent security alert activity. For each PR, show the type of alert, date detected, and current status.
```
