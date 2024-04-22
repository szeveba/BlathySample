from __future__ import annotations

class Menu:
    def __init__(self) -> None:
        self.options = []

class MenuOption:
    def undefined_action() -> None:
        print("Action is undefined!")
    
    def __init__ (self, label: str, key: str, action: callable = lambda: MenuOption.undefined_action()) -> None:
        self.label = label
        self.key = key
        self.action = action