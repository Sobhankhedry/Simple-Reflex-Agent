# Agent Vacum Cleaner Simulation

This project simulates a simple vacuum cleaner agent that navigates between two rooms and cleans them if they are dirty. The agent starts in one of the rooms, checks the room's cleanliness status, and takes appropriate actions (cleaning or moving to the next room) until both rooms are clean.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Usage](#usage)
- [Example Output](#example-output)
- [Contributing](#contributing)
- [License](#license)

## Overview
The `Agent` class models a basic vacum cleaner with the following functionalities:
- Detects whether rooms are clean or dirty.
- Cleans rooms as necessary.
- Moves between two rooms until both are clean.
  
## Features
- **Room Detection**: Identifies whether each room (Left and Right) is clean or dirty.
- **Room Cleaning**: Simulates cleaning by "sucking" dirt from the room if dirty.
- **Navigation**: Moves between rooms based on the current state of cleanliness.
- **Recursive Approach**: Uses recursive calls to handle the cleaning and movement logic.

## Usage
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/agent-vacum-cleaner.git
   cd agent-vacuum-cleaner
   ```
2. Compile and run the project:
-You can compile and run the Agent.cs file in your preferred C# development environment.
3.Start the Simulation:

```bash
public static void Main(String[] args)
{
    CleanRoom("Left", "Suck", LeftRoom, RightRoom);
}
```
This starts the agent in the Left room with an initial cleaning action.

## Example Output
Here is an example of what the output might look like:

```bash
Left Room is already clean and going to Right
Sucked the dirt in the Right room and we will go to Left room
Left Room is already clean and going to Right
Right Room is already clean and going to Right
all rooms are clean
```

## Contributing

Feel free to submit issues or pull requests for improvements or additional features. Contributions are welcome!

## License
This project is licensed under the MIT License. See the LICENSE file for details.
```bash

Replace `https://github.com/your-username/agent-vacuum-cleaner.git` with the actual URL of your GitHub repository if needed. This `README.md` covers the main details and should provide enough information for users to understand and run your simulation project.

```

