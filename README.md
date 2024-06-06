# PDF Merger Application

## Overview
The PDF Merger Application is a Windows Forms application built with C# that allows users to merge multiple PDF files into a single document. The application provides an intuitive interface for selecting, organizing, and managing PDF files before merging them. It leverages the `iTextSharp` library to handle PDF operations.

## Features

### Select Multiple PDF Files
- **File Selection:** Easily select multiple PDF files using the "Select Files" button. This opens a file dialog that allows for multiple selections.
- **Drag-and-Drop Support:** Users can drag and drop PDF files directly into the application, making it quicker to add files.

### Organize Files
- **Move Files Up and Down:** The application provides buttons to move selected files up or down in the list, allowing users to change the order of files before merging.
- **Remove Files:** A dedicated button allows users to remove any selected file from the list.

### Merge PDF Files
- **Merge Functionality:** Once the files are organized, users can merge them into a single PDF document by clicking the "Merge Files" button. A save dialog will prompt the user to specify the location and name of the merged file.
- **File List Display:** The selected PDF files are displayed in a list, showing their names for easy reference.

## How to Use

1. **Selecting Files:**
   - Click the "Select Files" button to open the file dialog.
   - Select one or more PDF files and click "Open."
   - Alternatively, drag and drop PDF files into the list box.

2. **Organizing Files:**
   - Use the "Move Up" and "Move Down" buttons to reorder the files.
   - Select a file and click "Remove File" to delete it from the list.

3. **Merging Files:**
   - Click the "Merge Files" button.
   - Choose the save location and filename for the merged PDF in the save dialog.
   - Click "Save" to merge the files.

## Getting Started
### Download unsigned executable.


### Prerequisites
- Visual Studio with .NET Framework support
- `iTextSharp` library (install via NuGet Package Manager)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/pdf-merger.git
