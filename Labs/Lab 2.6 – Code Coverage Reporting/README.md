# Lab 2.6 – (Optional): Code Coverage Reporting with Copilot Agent Mode

This **optional** lab introduces GitHub Copilot Agent Mode for automating common development tasks using natural language prompts. You will use Agent Mode to set up, generate, and view code coverage reports for your backend project—no prior experience with coverage tools required.

## Prerequisites
- The prerequisites steps must be completed, see [Labs Prerequisites](../Lab%201.1%20-%20Pre-Flight%20Checklist/README.md)

## Estimated time to complete

- 10 minutes.

## Objective
- Experience how Copilot Agent Mode can automate repetitive tasks and streamline code quality reporting, all with simple, conversational prompts.
  - Step 1: Ask Copilot Agent for Code Coverage Insights
  - Step 2: Request a Complete Automated Setup
  - Step 3: Approve or Guide the Agent
  - Step 4: Watch Agent Mode Work
  - Step 5: Review and Explore

---

## Step 1: Ask Copilot Agent for Code Coverage Insights

- Open **GitHub Agent Mode**.

- Click `+` to clear prompt history.

- Type the following prompt:

```plaintext
How do I get insights on test coverage for my backend project and how do I display the test coverage in the browser?
```

Copilot will respond with guidance on common tools and approaches for .NET code coverage (like Coverlet, ReportGenerator, or Cobertura reports).

## Step 2: Request a Complete Automated Setup

Let’s see Agent Mode in action by requesting an end-to-end setup:

- In **GitHub Agent Mode**.

- Type the following prompt:

```plaintext
Add a .NET code coverage tool for unit tests, generate a Cobertura-style report, and serve it in the browser. Install everything needed automatically.

🛑 Stop after completing this step so I can review the project setup.
```

> *Tip:* Agent Mode understands step-by-step tasks, so it should offer to install dependencies, update your test workflow, and generate the report.

- Click `Continue` to let Copilot proceed with task installations. Agent mode will ask for confirmation before making changes many times.


## Step 3: Approve or Guide the Agent

Depending on your Agent Mode settings, Copilot might pause for confirmation or offer a summary before taking action.

- If prompted, reply:

  ```plaintext
  Yes, install the coverage tools and set up the reporting.

  🛑 Stop after completing this step so I can review the project setup.
  ```

- Click `Continue` to let Agent Mode `Open untrusted web page` for coverage_html/index.html report.

- If the report doesn’t open automatically, you can view it by copying the URL from the Agent Mode panel and pasting it into your browser.
  - Example: `/GitHubCopilot-BeyondTheBasics\coverage_html\index.html`

- Review the report and make sure it displays correctly.

## Step 4: Watch Agent Mode Work

Once you’ve approved (or Agent Mode proceeds automatically), Copilot Agent Mode will

- Install any necessary coverage tools for your backend project.
- Run your test suite and generate a Cobertura-style coverage report.
- Set up an easy way for you to view the report in your browser (such as generating an HTML report and launching it with a local server).

- You’ll see progress updates and instructions in the Agent Mode panel.

- Wait for Agent Mode to complete all steps before moving on.

## Step 5: Review and Explore

- Open the code coverage report in your browser (the agent will tell you where).
- Identify which parts of your code are tested and where you have gaps.

- Using **GitHub Agent Mode**.

- Type the following prompt:

```plaintext
Can you highlight any controllers or methods with low or zero test coverage?
```

Let Agent Mode summarize which parts of the backend could use more testing!

## Why This Matters

Copilot Agent Mode isn’t just about writing code—it can automate whole dev tasks from setup to reporting. In this lab, you’ve used Agent Mode to set up a full code coverage workflow with just a few prompts. This is a great example of how natural language can streamline developer productivity.

### Congratulations you've made it to the end! &#9992; &#9992; &#9992;

#### And with that, you've now concluded this module. We hope you enjoyed it! &#x1F60A;