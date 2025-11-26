# Tanach Word and Gematria Search

## Project Description

This project enables advanced search capabilities in the text of the **Tanach (Hebrew Bible)**, including search by **Gematria** (Hebrew numeric values). The search is performed **efficiently** using preprocessed **JSON files** for fast data access.

The project is written in **C#** and optimized for performance and clarity.

---

## Features

-  Search for words and phrases in the Tanach
-  Search by Gematria value of words or verses
-  High performance using preprocessed JSON data
-  Clear and structured output (book, chapter, verse)
-  Based on the full text of the Hebrew Tanach

---

## File Structure

- `TanachData.json` – Full text of the Tanach, structured by books, chapters, and verses
- `GematriaIndex.json` – Index mapping Gematria values to words/verses for fast lookup
- C# source files – Handle JSON reading, Gematria calculation, and search execution

---

## Requirements

- .NET 6.0 or later
- C# compatible system (Windows, Linux, or macOS with .NET installe
