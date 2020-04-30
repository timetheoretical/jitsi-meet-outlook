# Jitsi Meet Outlook Add-In
## Introduction
This is a small plug-in that aims to integrate Jitsi Meet with Microsoft Outlook. Specifically, it adds two main features:
1. A button in the Outlook calendar tab that opens a new appointment and inserts a randomly generated Jitsi Meet URL.
2. A set of controls in the Outlook appointment window that, for example, allows for specification of a Room ID of choice and whether participants will be muted upon entry to the room.

It was created to fulfil [this](https://community.jitsi.org/t/plug-ins-for-adding-jitsi-meet-links-to-appointment-requests-emails/21564) request, and more generally with a view to facilitate organisational use of Jitsi Meet. This project is not affiliated with that of Jitsi Meet nor its creators.

The screenshots below display the features of implemented in this add-in.

## Screenshots
### Calendar view
<br/><img src="images/modified_calendar.png" width="500">

### Appointment view
<img src="images/modified_appointment.png" width="500">

### Settings
<img src="images/settings.png" width="200">


## Installation
### New
Go to the [installers](installers) folder and download the latest version. Unzip the file contents and then run the setup_<architecture>.msi file that matches the architecture of your installation of Microsoft Office. I.e. if Office was installed as 64-bit, then run setup_x64.msi.

### Upgrade
Please uninstall any previously installed version of this add-in via the "Add or remove programs" pane in Windows before updating.

### Uninstall
The add-in can be uninstalled via the "Add or remove programs" pane in Windows, or by running the setup_<architecture>.msi file again.

## Roadmap
The published code and installer is still at an early stage. Preliminarily, the following amendments are in the pipeline:
- [x] Make the installation procedure less painful (v0.2)
- [x] Add small icons to the buttons in the appointment ribbon (v0.2)
- [ ] Shift the controls in the appointment ribbon to the left
- [x] Add a button for starting a conference with video muted to appointment tab (v0.2)
- [x] Only show Jitsi buttons if appointment was created through "New Jitsi Meeting" (v0.2)
- [x] Add persistent setting: change Jitsi domain (v0.2)
- [ ] Add persistent setting: add URL to Location field of appointment
- [ ] Add persistent setting: preference for whether to start a call with muted mic or video
- [ ] Add RTF body text to appointment for improved appearance
- [x] Add checks on the validity of the custom domain value provided (v0.2.1)
- [ ] Add checks for Outlook having been installed on the target computer and that its architecture matches that of the installer
- [x] Widen the custom Room ID field (v0.2.1)


Since this plug-in is brand new, any feedback would be most appreciated!

## Changelog

### v0.2.1
* Bug fixes related to specification of a custom domain
* Custom domain names provided by user now has to pass a validity check
* Improved layout in the appointment view (widened Room ID field and reorganisation of buttons)

### v0.2
* The installer no longer prompts trust certificate issues and delegates trust decision to user
* Small icons have been added to the buttons in the appointment ribbon
* A button for starting with the video turned off has been added to the appointment ribbon
* The appointment ribbon buttons are only displayed for appointments created via the "New Jitsi Meeting" button in the calendar tab
* Persistent settings have been enabled
* It is now possible to specify a custom domain in the settings dialogue
* Various small bugs have been fixed to improve reliability

### v0.1
* Initial release of the project
