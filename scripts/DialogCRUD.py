import csv
import json
import sqlite3
import uuid 
import os.path as path

# static class for handling CRUD operations on Dialog Data
class Dialog:
    
    def create() -> str:
        pass

    def read() -> str:
        pass

    def update() -> str:
        pass

    def delete() -> str:
        pass

def parse_input(i: int):

    commands_dict = {
        1: Dialog.create,
        2: Dialog.read,
        3: Dialog.update,
        4: Dialog.delete
    }

    return commands_dict[i]

if __name__ == "__main__":
    

    while True:
        pass

