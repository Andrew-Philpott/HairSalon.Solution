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

| Search | /stylists/search/{name} | GET | Displays list of all stylists with the name in the query string |

| Create | /stylists/create | GET | Offers a form to create a stylist |

| Create | /stylists | POST | Create a new stylist object |

| Details | /stylists/{id} | GET | Displays details of a specific stylist |

| Delete | /stylists/{id}/delete | Get | Offers a from to delete a stylist |

| DeleteConfirmed | /stylists/{id} | POST | Deletes a specific stylist |

| Index | /clients | GET | Displays list of all clients |

| Search | /clients/search/{name} | GET | Displays list of all clients with the name in the query string |

| Create | /clients/create | GET | Offers a form to create a client |

| Create | /clients | POST | Create a new client object |

| Details | /clients/{id} | GET | Displays details of a specific object |

| Delete | /clients/{id}/delete | Get | Offers a from to delete a client |

| DeleteConfirmed | /clients/{id} | POST | Deletes a specific client |

</details>

## Description

C#/.NET MVC website that allows a manager to create stylists and clients and view their relationships.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the HairSalon directory, within the HairSalon.Solution directory
- \$dotnet restore
- Recreate our database structure with migration: (Please note that the connection string is for sqlserver)
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
