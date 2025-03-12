
<a id="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Unlicense License][license-shield]][license-url]


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/ragnarokk12/TigrisBorrow1">
    <img src="https://github.com/ragnarokk12/TigrisBorrow1/blob/master/Logo/W1.png" alt="Logo" width="500" height="179">
  </a>

  <h3 align="center">TigrisBorrow</h3>

  <p align="center">
    An Online Borrowing System for Computer Science Students
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template">View Demo</a> <!-- will be changed -->
    &middot;
    <a href="https://github.com/ragnarokk12/Best-README-Template/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    &middot;
    <a href="https://github.com/ragnarokk12/Best-README-Template/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

The **MIS Department** at **LPU Laguna** currently relies on a **manual or paper-based system** to track borrowed and returned equipment. This leads to challenges such as:

- **Difficulty tracking borrowed items** – No real-time monitoring of equipment status.
- **Manual errors** – Paper-based records can be misplaced or incorrectly updated.
- **Lack of notifications** – No automated reminders for overdue equipment.

### **Project Benefits**
✅ **Improved Equipment Management** – Maintains a digital inventory with real-time tracking of available and borrowed items.  
✅ **Automated Notifications** – Sends email alerts for due dates and overdue returns.  
✅ **Efficiency & Accuracy** – Eliminates human errors and speeds up processing.  
✅ **Report Generation** – Generates reports on borrowing trends and usage statistics.  

### **Key Features**
- **Equipment Registration** – Stores details like name, type, serial number, and availability status.
- **Condition Tracking** – Logs equipment condition before and after borrowing.
- **Borrowing & Returning System** – Real-time tracking of borrower details, due dates, and return status.
- **User Authentication & Access Control** – Role-Based Access Control (RBAC) for different user levels.
- **Admin Dashboard** – Centralized management for equipment, users, and reports.
- **Item Visibility Control** – Students can browse available equipment but cannot see quantity.

### **Role-Based Access Control (RBAC)**
| Role | Permissions |
|------|------------|
| **Admin** | Full system control (manage users, equipment, permissions, reports) |
| **Staff** | Assists in managing equipment and processing requests but cannot modify user roles |
| **Student** | Can browse equipment and submit borrowing requests |

### **CRUD Permissions**
| Feature | Admin | Staff | Student |
|---------|-------|-------|---------|
| Create Equipment | ✅ | ❌ | ❌ |
| Read Equipment | ✅ | ✅ | ✅ (Limited) |
| Update Equipment | ✅ | ✅ | ❌ |
| Delete Equipment | ✅ | ❌ | ❌ |
| Submit Borrow Request | ❌ | ❌ | ✅ |
| Approve/Reject Requests | ✅ | ✅ | ❌ |

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

* [![.NET](https://img.shields.io/badge/.NET-Framework-purple?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
* [![SQL](https://img.shields.io/badge/SQL-Database-blue?style=for-the-badge)](https://www.w3schools.com/sql/)
* [![Visual Studio](https://img.shields.io/badge/Visual%20Studio-SQL-blueviolet?style=for-the-badge&logo=visual-studio&logoColor=white)](https://learn.microsoft.com/en-us/sql/ssms/sql-server-management-studio-ssms)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Add	Overdue Notifications
- [ ] Add -	Availability Calendar
- [x] Multi-language Support
    - [x] English
    - [ ] Tagalog

See the [open issues](https://github.com/ragnarokk12/TigrisBorrow1/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTRIBUTING -->
## Contributing

Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Top contributors:

<a href="https://github.com/ragnarokk12/TigrisBorrow1/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ragnarokk12/TigrisBorrow1" alt="contrib.rocks image" />
</a>

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the Unlicense License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Nada

Project Link: [https://github.com/ragnarokk12/TigrisBorrow1](https://github.com/ragnarokk12/TigrisBorrow1)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

Special Thanks:

* [ChatGPT](https://chatgpt.com/)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/ragnarokk12/TigrisBorrow1/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/ragnarokk12/TigrisBorrow1/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/ragnarokk12/TigrisBorrow1/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/ragnarokk12/TigrisBorrow1/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/ragnarokk12/TigrisBorrow1/blob/master/LICENSE.txt
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 

