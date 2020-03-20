# Salon

#### C#/.NET MVC website that organizes tracks stylists and clients: 03.20.20

#### By Andrew Philpott

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [Specifications](#specs)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

<details>
  <summary>Click to expand!</summary>
| Route Name | URL Path | HTTP Method | Purpose |
| :--------- | :------- | :---------- | :------- |
| Index | / | GET | Homepage: displays welcome message & link to view clients and stylists |

| Index | /stylists | GET | Displays list of all stylists |

| Create | /stylists/create | GET | Offers a form to create a stylist |

| Create | /stylists | POST | Create a new stylist object |

| Details | /stylists/{id} | GET | Displays details of a specific stylist |

| Edit | /stylists/{id}/edit | GET | Offers form to edit a specific stylist |

| Update | /stylists/{id} | PATCH (via POST) | Updates a specific stylist |

| Delete | /stylists/{id} | POST | Deletes a specific stylist |

| Index | /clients | GET | Displays list of all clients |

| Create | /clients/create | GET | Offers a form to create a restaurant |

| Create | /restaurtants | POST | Create a new restaurant object |

| Details | /restaurtants/{id} | GET | Displays details of a specific object |

| Edit | /restaurtants/{id}/edit | GET | Offers form to edit a specific restaurant |

| Update | /restaurtants/{id} | PATCH (via POST) | Updates a specific restaurant |

| Delete | /restaurtants/{id} | POST | Deletes a specific restaurant |

</details>

## Description

C#/.NET MVC website that organizes restaurant based on cuisine. This application allows you to create cuisines and restaurants per type of cuisine. The website will prompt you to register an account and log in to view restaurants. Then you can view, create, delete, and update your cuisines and restaurants. This project focuses on using .NET Core MVC, Authentication, SQL databases/Migration, and many-to-many design for data.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the Salon directory, within the Salon.Solution directory
- \$dotnet restore
- Recreate our database structure with migration:
  - \$dotnet ef migrations add Initial
  - \$dotnet ef database update
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
