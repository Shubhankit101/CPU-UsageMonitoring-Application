# CPU Usage Monitor (macOS & Linux)

## 📌 Overview

This is a simple CPU Usage Monitor written in C#. It continuously tracks and displays the total CPU usage percentage in real-time. The program is designed to work exclusively on macOS and Linux.

## 🚀 Features

Retrieves total CPU usage using system commands.

Refreshes the CPU usage value every second.

Runs in the terminal and can be stopped with Ctrl+C.

## 🖥️ How It Works

The program executes a shell command (ps -A -o %cpu | awk '{s+=$1} END {print s}') to calculate the total CPU usage and then displays it in real-time.

## 🛠️ Prerequisites

Operating System: macOS or Linux

.NET SDK (at least .NET Core 3.1+)

C# Compiler (csc) or dotnet CLI

## 📥 Installation

Clone the repository:

<pre><code>git clone https://github.com/your-username/cpu-usage-monitor.git
cd cpu-usage-monitor
</code></pre>


Ensure .NET is installed:

<pre><code>dotnet --version</code></pre>

If not installed, follow this guide.

## ▶️ Usage

Run the Program

Compile the program:

dotnet build

Run the executable:

dotnet run

Stop the program using Ctrl+C.

## 📜 Code Explanation

Uses C#'s Process class to execute a shell command.

The command fetches CPU usage using ps and awk.

The result is parsed and displayed every second.

## ❗ Limitations

❌ Does not work on Windows (Windows lacks ps and awk).

⚠️ Requires Bash-compatible shell (e.g., sh, bash).

