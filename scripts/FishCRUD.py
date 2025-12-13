import csv
import json
import sqlite3
import os.path
import uuid

DATA_DIRECTORY = ""
dirname = os.path.abspath("../data")

# Static Fish Class 
class Fish():

    # TODO: Implement
    def read_fish() -> str:
        print("test")

    # TODO: Implement
    def create_fish() -> str:
        
        fish_data = {
            "id": str(uuid.uuid4()), 
            "name": input("Input Fish Name: "),
            "strength": int(input("Input Fish Str: ")),
            "speed": int(input("Input Fish Speed: ")),
            "description": ""
        }

        return json.dumps(fish_data)

    # TODO: Implement
    def delete_fish() -> str:
        pass

    # TODO: Implement
    def update_fish() -> str:
        pass

# TODO: Implement
def initialize_fish_file():
    
    FILENAME = ""

    full_path = os.path.join(DATA_DIRECTORY, FILENAME)

    print(dirname)

# TODO: Implement
def parse_command(command: int):

    print("What would you like to do?")

    print('''
1. Read Fish Data
2. Create New Fish Data
3. Update Fish Data
4. Delete Fish Data
5. Initialize Fish File
6. Exit
          ''')

    command_dict = {
        1: Fish.read_fish,
        2: Fish.create_fish,
        3: Fish.update_fish,
        4: Fish.delete_fish,
        5: initialize_fish_file,
        6: exit
    }

    return command_dict[command]

if __name__ == "__main__":

    print("Welcome to Fish Editor")

    print('''
1. Read Fish Data
2. Create New Fish Data
3. Update Fish Data
4. Delete Fish Data
5. Initialize Fish File
6. Exit
          ''')

    while True:
        c = parse_command(int(input()))

        c()