# 🛩️ GitHub Copilot Demos – Wright Brothers Frontend

A hands-on demo series to power up your frontend with GitHub Copilot, from project setup to real-world automation. Each step clearly states whether to use Copilot **Agent Mode (Chat)** or **Edit Mode** for the best result.

---

## Estimated Time

- 60 minutes

> [!IMPORTANT] 
> This is used for GitHub Copilot Fundamentals trainings.

---

## Step 1: Cleared for Takeoff – Setup & Explore

**Best Mode: Agent Mode (Chat)**

Get your project running and explore its structure using Copilot Chat.

### Actions

* Open a terminal:

  ```bash
  cd WrightBrothersFrontend/
  npm install
  npm run frontend
  ```
* Open [http://localhost:5173/](http://localhost:5173/) in your browser.

### Copilot Agent Mode Prompt

```prompt
@workspace What’s the tech stack, structure, and main entry files for this frontend app? Where do I find the main Home page?
```

---

## Step 2: Connecting the Dots – API Integration & State Management

**Best Mode: Edit Mode**

Fetch real backend data and handle all loading/error states in your Home page.

### Copilot Edit Mode Prompt

```prompt
Update HomePage.tsx to:
- Fetch the plane list from http://localhost:1903/planes using axios
- Use react-query to manage loading and error states
- Show PlaneSpinner when loading, and an error message on failure
```

* Run your app to verify you’re seeing real backend data (not a static list).

---

## Step 3: Dawn of Aviation – UI Tweaks & Accessibility

**Best Mode: Edit Mode**

Upgrade the look and usability of the banner with a single Copilot prompt.

### Copilot Edit Mode Prompt

```prompt
Update Banner.tsx to:
- Center the banner title horizontally
- Add 10% more vertical spacing between the title and subtitle
- Adjust the subtitle color for strong contrast and readability
- Add two visually distinctive call-to-action buttons below the subtitle
```

* Preview the result and adjust as needed.

---

## Step 4: In-Flight Entertainment – Interactive Components

**Best Mode: Edit Mode**

Add the ability to create a plane from the UI, in two steps or a single prompt if you prefer.

### Copilot Edit Mode Prompt

```prompt
1. Create an AddPlaneButton component styled like PlaneList, with a plus icon and hover effect. Place it below the Banner on HomePage.
2. Update NewPlane.tsx to include all fields matching the Plane backend model, using Tailwind for layout, and POST to http://localhost:1903/planes when submitted. Each input should have a label.
```

* Test your “Add Plane” workflow in the browser.

---

## Step 5: Carbon Reinforced Fuselage – Linting & Dependency Hardening

**Best Mode: Edit Mode (plus Chat for insights)**

Make your codebase safer, cleaner, and more modern in a single batch.

### Copilot Edit Mode Prompt

```prompt
1. Review .eslintrc.cjs and suggest additional linting rules to harden the project (avoid any already in recommended sets). Apply them and explain why each is useful.
2. Run npm run lint and fix all flagged issues using Copilot.
3. Review package.json for outdated or insecure dependencies and update them if needed.
```

* Use Chat if you want to know *why* Copilot suggests any particular lint rule or dependency update.

---

## Step 6: Visual Testing – Playwright UI Tests

**Best Mode: Edit Mode for code, Agent Mode for troubleshooting**

Extend your UI/component tests and get help debugging as needed.

### Copilot Edit Mode Prompt

```prompt
Open PlaneList.tsx and PlaneList.spec.tsx.
Generate additional component and visual tests for PlaneList (based on current implementation), ensuring a variety of cases.
Help debug and fix any failing tests so all pass with npm run test-ct:open.
```

* Run your tests:

  ```bash
  npm run test-ct
  npm run test-ct:open
  ```
* If a test fails, use Copilot Chat:

  ```prompt
  Why is this Playwright test failing? What’s the fix?
  ```

---

## Step 7: E2E Automation with Copilot Agent Mode

**Best Mode: Agent Mode (Chat/Agent)**

Level up—let Copilot generate an end-to-end Playwright test for your UI, from natural language alone.

### Copilot Agent Mode Prompt

```prompt
Generate a complete Playwright end-to-end test for my React app that:
1. Opens the homepage at http://localhost:5173/
2. Clicks the "Add Plane" button.
3. Fills out the new plane form with realistic test values (for all required fields).
4. Submits the form.
5. Waits for the navigation or UI update.
6. Verifies that the newly added plane appears in the plane list.
7. Cleans up if needed.

Use best practices for Playwright tests, including selectors that match my UI, and add comments to each step. If needed, update any test setup/config to ensure the test runs successfully. Output all code as a single test file (e.g., add-plane-e2e.spec.ts). Once done, explain how to run the test locally.
```

* Review Copilot’s code output, save the file, and run:

  ```bash
  npx playwright test add-plane-e2e.spec.ts
  ```

---

## 🏁 Mission Accomplished!


