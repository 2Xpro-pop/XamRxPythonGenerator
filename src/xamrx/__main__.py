from pathlib import Path
from string import Template
from importlib import resources
from command import Command
import yaml
import sys

KEYWORDS = ['commands']

__path__ = str(Path(__file__).parent.absolute())
__templates_path__ = "templates"

xamrx_vars = {}
commands = { 0: Command("0", xamrx_vars, __templates_path__)}

#read config
with open("xamrx.yaml", "r") as stream:
    try:
        pass
        config = yaml.safe_load(stream)
    except yaml.YAMLError as exc:
        print(exc)

for k,v in config.items():
    if(k not in KEYWORDS):
        xamrx_vars[k] = v
        if(v.startswith("$")):
            xamrx_vars[k] = sys.argv[int(v.replace("$",""))]

for name,ins in config['commands'].items():
    commands[name] = Command(name, xamrx_vars, __templates_path__)
    for i in ins:
        commands[name].add_instruction(i['template'],i['path'])

commands[sys.argv[1]].run()