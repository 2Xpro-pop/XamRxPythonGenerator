import os
from string import Template
from importlib import resources

class Command:

    def __init__(self, name, xamrx_vars, templates_path) -> None:
        self.name = name
        self.__instasractions = []
        self.xamrx_vars = xamrx_vars
        self.templates_path = templates_path

    def add_instruction(self, template, path):
        path = Template(path).substitute(**self.xamrx_vars)
        template = Template(template).substitute(**self.xamrx_vars)
        self.__instasractions.append({'template':template, 'path':path})

    def run(self):
        for ins in self.__instasractions:
            os.makedirs(os.path.dirname(ins["path"]), exist_ok=True)
            with open(ins["path"], "w+", encoding="utf-8") as file:
                template = render_template(ins["template"]+".template",self.xamrx_vars, self.templates_path)
                file.write(template)

def render_template(path, xamrx_vars, templates_path):
    return Template(resources.read_text(templates_path,path, encoding="utf-8")).substitute(**xamrx_vars)