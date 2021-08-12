# Setting up virtual environment

### If you are using **Linux** you should use `venv`
### If you are using **Windows** you should use `virtualenv`

## If you try to run `virtualenv` and find it isn’t present, you can install it using
```shell
pip install virtualenv
```

## Creating virtual environment
### Linux
```shell
python -m venv /path/to/env/[environment-name]
```
### Windows
```shell
virtualenv --python C:\Path\To\Python\python.exe [environment-name]
```

## Entering virtual environment
### Linux
```shell
source /path/to/env/[environment-name]/bin/activate
```
### Windows
```shell
.\path\to\env\[environment-name]\Scripts\activate
```

## Now you are in virtual environment
### You can install packages using
```shell
pip install
```

### You can see installed packages using
```shell
pip freeze
```

### You can save installed packages using
```shell
pip freeze > requirements.txt
```

### You can install packages from list using
```shell
pip install -r requirements.txt
```

### You can leave virtual environment using
```shell
deactivate
```

## Additional info
### You cant move environments by copying them, but you can create new environment in new location and install same packages using
### In old location:
```shell
pip freeze > requirements.txt
```

### In new location:
### Linux
```shell
python -m venv /path/to/env/[environment-name]
source /path/to/env/[environment-name]/bin/activate
pip install -r /path/to/old/location/requirements.txt
```
### Windows
```shell
virtualenv --python C:\Path\To\Python\python.exe [environment-name]
.\path\to\env\[environment-name]\Scripts\activate
pip install -r /path/to/old/location/requirements.txt
```

## Useful links
* [python.org - "Installing packages using pip and virtual environments"](https://packaging.python.org/guides/installing-using-pip-and-virtual-environments/)
* [mothergeo-py - "How To Set Up a Virtual Python Environment (Windows)"](https://mothergeo-py.readthedocs.io/en/latest/development/how-to/venv-win.html)
* [Stack Overflow - "How to use the same Python virtualenv on both Windows and Linux"](https://stackoverflow.com/questions/42733542/how-to-use-the-same-python-virtualenv-on-both-windows-and-linux)