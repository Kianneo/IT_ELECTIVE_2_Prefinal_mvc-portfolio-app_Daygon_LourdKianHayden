# DaygonPortfolio - ASP.NET Core MVC Portfolio Application

[![NET Core](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/Framework-ASP.NET%20Core%20MVC-512BD4?style=flat-square)](https://dotnet.microsoft.com/apps/aspnet)
[![UI Framework](https://img.shields.io/badge/UI-Bootstrap%205.3-7952B3?style=flat-square&logo=bootstrap)](https://getbootstrap.com/)

A web application developed using **ASP.NET Core MVC** designed to showcase academic repositories, C# backend projects, and coursework for **IT Elective 2**. It features dynamic project rendering, a high-contrast accessible interface, detailed repository views, and an interactive project feedback system.

---

## Key Features

* **Dynamic Repository Showcase:** Displays a full directory of 15 public GitHub repositories complete with descriptions, repository IDs, and direct source links.
* **High-Contrast Light Theme:** Accessible, clean UI using solid navy/black typography (`#0f172a`) on bright cards for optimal readability without visual strain.
* **Detailed Project View:** In-depth pages for each project highlighting comprehensive overviews, model binding architecture, and source code links.
* **Interactive Discussion & Feedback System:** Embedded comment section on project detail pages allowing users to post real-time notes and feedback.
* **Responsive Layout:** Mobile-friendly design utilizing Bootstrap 5 grid layouts and scalable visual banners.

---

## Tech Stack

* **Backend:** C#, .NET 8.0, ASP.NET Core MVC Architecture
* **Frontend:** Razor Views (`.cshtml`), HTML5, CSS3, Bootstrap 5.3, FontAwesome 6.4
* **Development Tools:** Visual Studio 2022, Git, GitHub

---

## Featured Repositories

| ID | Repository Name | Description |
| :---: | :--- | :--- |
| **01** | `IT_ELECTIVE_2_Prefinal_mvc-portfolio-app` | ASP.NET Core MVC Portfolio featuring dynamic project listing and discussion system. |
| **02** | `IT_ELECTIVE_2_PREFINAL_EXAM` | Prefinal Examination implementation demonstrating advanced C# backend logic. |
| **03** | `IT_ELECTIVE_2_MIDTERM_EXAM_6` | Midterm practical exam covering web development principles and layout rendering. |
| **04** | `IT_ELECTIVE_2_MIDTERM_Q3` | Midterm Quiz 3 focusing on web interface design and HTML components. |
| **05** | `IT_ELECTIVE_2_MIDTERM_H1_H2_H3` | Combined implementation of Midterm Hands-on tasks covering modular HTML layout. |
| **06** | `IT_ELECTIVE_2_MIDTERM_Q2` | Implementation of Midterm Quiz 2 based on university template structure. |
| **07** | `IT_ELECTIVE_2_ModelBinding` | ASP.NET Core MVC Model Binding demonstration for BSIT 31E2. |
| **08** | `PersonalityTest` | Web application computing personality trait assessments dynamically. |
| **09** | `IT_Elective_HACKATHON_4` | Collaborative C# solution created during Hackathon 4 focusing on rapid software build. |
| **10** | `IT_ELECTIVE_2_Midterm_A1` | First midterm assignment repository focusing on fundamental web design practices. |
| **11** | `ite-two-prelim-assignment-two` | C# programming assignment covering core software design requirements. |
| **12** | `ite-two-prelim-assignment-one` | Preliminary course assignment focusing on basic project setups and logic. |
| **13** | `IT_ELECTIVE_2_PRELIM_EXAM` | Hands-on preliminary examination covering initial course learning modules. |
| **14** | `HttpServer` | Low-level C# custom HTTP server handling socket connections and HTTP requests. |
| **15** | `BSIT_31E2_PRELIM_Q1` | Preliminary quiz submission containing basic project structure and fundamental logic. |

---

## Project Structure

```text
DaygonPortfolio/
├── Controllers/
│   ├── AuthController.cs          # Authentication & admin logic
│   └── HomeController.cs          # Project routing, details, & comment handling
├── Models/
│   ├── Comment.cs                 # Comment data model
│   └── Project.cs                 # Project data model
├── Views/
│   ├── Home/
│   │   ├── Details.cshtml         # Project detail view with comment form
│   │   ├── Index.cshtml           # Main portfolio directory grid
│   │   └── Privacy.cshtml         # Privacy policy view
│   └── Shared/
│       └── _Layout.cshtml         # Global layout, header, footer, & styles
└── wwwroot/
    └── image/                     # Project image assets
