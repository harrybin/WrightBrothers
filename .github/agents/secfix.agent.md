---
name: Security Fix (Orchestrator)
description: 'Security Fix Orchestrator: Identify, Implement, and Verify Security Fixes'
argument-hint: 'Pick a controller to check for issues'
tools: ['agent/runSubagent']
model: GPT-5 mini (copilot)
infer: false
---

## Orchestrated Security Fix Cycle

This agent orchestrates a comprehensive security fix process by invoking each subagent via #tool:agent/runSubagent (MUST be with `subagentType`) in the following strict order:

1. subagentType=`secfix-identify`: Scan the codebase to identify potential security vulnerabilities and generate a report.
2. subagentType=`secfix-implement`: Based on the identified vulnerabilities, implement the necessary security fixes in the codebase.
3. subagentType=`secfix-verify`: Verify that the implemented security fixes effectively resolve the vulnerabilities without introducing new issues.