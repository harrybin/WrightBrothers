## Automating with `mcp-playwright` (MCP Playwright) Testing

## Getting Started

✅ **Create a new empty folder** — e.g. `eShopOnWeb-Demo`, then **open it in VS Code**.

  ```bash
  mkdir eShopOnWeb-Demo && cd eShopOnWeb-Demo
  ```

✅ **Enable Agent Mode**:
   - Click the **Extensions** icon in the VS Code sidebar.
   - Search for **Python** (by Microsoft).
   - Click **Install**.

✅ **Open Agent Mode Chat**:
- Open the **Copilot Ask** sidebar.
- Make sure **Agent Mode** is toggled on.
- You’re now ready to start pasting the prompts below.

✅ **Install Playwright**, make sure Playwright is installed:

- Open the terminal in VS Code.
- Run the following commands:

  ```bash
  npm init playwright@latest --yes "--" . '--quiet' '--browser=chromium' '--browser=firefox' '--gha'
  ```

---

✅ You're all set to run this demo with GitHub Copilot Agent Mode. Paste each block below one at a time and enjoy the ride!

---

## Using `mcp-playwright` for Automated Testing - Shopping

### Steps to Demo `mcp-playwright`:
1. Open Visual Studio Code with `GitHubCopilot_MCP_Playwright_Testing` folder.
  - i.e. Cloned from https://github.com/PagelsR/GitHubCopilot_MCP_Playwright_Testing

1. **Explain what Playwright is:**

   * Say:

     > “Playwright is a browser automation tool. And Copilot supports mcp-playwright so we can generate and run automated browser tests on this app — in real time.”

1. **Show the Configure Tools** — show that PlayWright is installed.

1. Click on the **Gear Icon** and select **Playwright**, then click **Start**.

1. **Explain MCP Playwright** — introduce the concept of using Copilot to generate Playwright tests.

1. **Navigate to the App** — briefly show the eShopOnWeb app.

> **Use Copilot Agent Mode** - Select model **GPT-4.1**

  **Prompt**

  ```bash
  please navigate to https://app-6swivue3g4dqc.azurewebsites.net/
  ```

1. Expand the `Ran playwright_navigate` command and show the commands.

1. Next, let's try some simple navigation commands.

**Prompt**

```bash
please click the dropdown button for brand and select .net, then click the submit button.
```

1. Great! Now, let's create a test to verify the page title.

**Prompt**

> Use **GitHub Copilot Agent Mode** - **Model GPT-4.1**

- Copy the contents from `Scenerio-Shop by Brand.md` and paste it into Chat.

- Click **Submit** and let Copilot generate the test file.

- Click **Continue** to proceed with the next steps.

1. **Wait, what's happening?**

   * Explain:

     > “Behind the scenes, Copilot is using MCP — the Model Context Protocol — to read the current file (brand_catalog.spec.ts), figure out what’s missing, and then generate just the new tests we asked for. Every time we prompt, it’s fetching the file, analyzing its contents, and iteratively improving it — that’s MCP in action!”

1. **Key Points:**

   * Highlight how Copilot **writes the test**.
   * Show the Playwright code to your audience — read one or two key lines.
   * Run the test (`npx playwright test`) and show green checkmarks.

    ```bash
    npx playwright test tests/brand_catalog.spec.ts
    ```

   * Explain:

     > “This is MCP-Playwright — Copilot generated this automation and ran it, validating the app without me writing the boilerplate myself!”
  * Say:

    > “With `mcp-playwright`, Copilot is creating the tests and verifying our live app as we demo — real automation magic!”

    > “I give Copilot a plan. It drafts a working Playwright test. I review and adjust selectors — and then let Agent Mode self-heal until it passes!”

---

## 🧭 **Demo Flow — What to Say and Do**

✅ **First**, run this prompt in Agent Mode and let Copilot produce the full file — your audience will see it build the entire Playwright test suite!

✅ **Next**, highlight:

> 🎙️ *“Here we asked Copilot to implement a detailed Playwright test suite with real selectors and validation logic — exactly like a human would.”*

✅ **Then**, run the tests (`npx playwright test`) so everyone can see green checks.

✅ **Finally**, introduce the `mcp-playwright` angle:

> 🎙️ *“With this baseline, we can now leverage MCP Playwright to generate variations, add error handling, or test additional edge cases — all driven by Agent Mode.”*

---

## Follow-Up Iteration Prompt — Enhance Existing Test

> 📝 “Agent, add a new test for the ‘Visual Studio’ option that also checks for a ‘No products’ message and a screenshot after submission.”

Show off **self-healing and iterative development** — the heart of MCP Playwright automation.


```markdown
## Enhance the Existing Playwright Test
Steps:
1. Update the existing `Shop by Brand.spec.ts` file.
2. Add a new test that:
   - Filters by the "Visual Studio" option.
   - Submits the form.
   - Checks that the displayed message contains "No products".
   - Takes a screenshot of the result and saves it as `visualstudio_no_products.png`.
3. Improve all existing tests by:
   - Adding a `page.screenshot()` after each successful filter & validation.
   - Including one additional validation to check that the `#CatalogModel_BrandFilterApplied` value matches the selected label.
4. 🛑 Stop after updating the file so I can review the changes.

Agent Mode Instructions:
- Edit the existing file in place — do not create a new file.
- Preserve all existing tests.
- Clearly highlight the new “Visual Studio” test and the new screenshot behavior.
```

---

## Using `mcp-playwright` for Automated Testing - Movie Database

### Step 1
Explore https://movies.zaps.dev/?category=Popular&page=1
Summarize what this website if used for.

### Step 2
Generate a test to find a Top Rated movies, pick one. Tell and tell what the synopsis is and the minutes. Generate this test in a trivial way to avoid matching public code.

### Step 3
Add 2 more tests. 1. toggle-mode and 2. searching

---

### Demo Flow Suggestion

✅ Run the first prompt → generate the baseline tests.
✅ Run this **follow-up prompt** → Agent iterates and enhances the existing file.
✅ Show the updated file and highlight the **new test and screenshots** feature.
✅ Finally, run `npx playwright test --headed` so you can show the screenshot files being saved!


