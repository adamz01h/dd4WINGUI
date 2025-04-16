# Crygwin DD GUI Wrapper (dd4WINGUI)

This project is a simple graphical user interface (GUI) that wraps **Crygwin's `dd`** utility, along with all required DLLs, into a single, easy-to-use application. It allows users to safely and efficiently use the power of `dd` without needing to interact with the command line.

## What is This?

`dd` is a powerful command-line utility used to copy and convert data at the byte level. It's commonly used for tasks such as:

- Creating bootable USB drives
- Backing up disks
- Writing raw disk images to storage devices

**Crygwin** is a lightweight runtime environment that brings Unix-like tools to Windows. This project packages Crygwin's version of `dd` with all necessary dynamic-link libraries (DLLs) and provides a GUI on top, so users can take advantage of `dd` without needing to install or configure anything manually.

## Features

- Simple graphical interface
- Portable — no installation required
- Bundled with all required DLLs
- Built-in logging
- Input validation for device paths and image files
- Compatible with most Windows systems

## How to Use

1. Launch the application by double-clicking the executable.
2. Select the input image file (e.g., `.img`, `.iso`).
3. Choose the target device (e.g., a USB drive).
4. Click **Write** to start the process.
5. Monitor progress and logs within the application.

> ⚠️ **Warning:** `dd` is a low-level tool and will overwrite data without warning. Be sure you've selected the correct device before writing.

## Why Use This?

Using `dd` on Windows typically requires:
- Installing Crygwin or another Unix-like environment
- Familiarity with command-line operations
- Ensuring all required DLLs are present and accessible

This tool eliminates all of that — it's a standalone executable that "just works."

## License

[MIT License](LICENSE) — free to use, modify, and distribute.

## Disclaimer

This tool is provided "as is" without warranty of any kind. Use at your own risk. The author is not responsible for any data loss or hardware damage resulting from misuse.

---

Made with ❤️ to make working with `dd` on Windows a little easier.
