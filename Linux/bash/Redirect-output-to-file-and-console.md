# Redirect process output to both file and console

### You have to use `2>&1 | tee -a`

## Example
```shell
python -u [python-file] 2>&1 | tee -a [output-file]
```

```shell
python -u main.py 2>&1 | tee -a output.log
```

## Useful links
* [ask ubuntu - "How do I save terminal output to a file?"](https://askubuntu.com/questions/420981/how-do-i-save-terminal-output-to-a-file)
* [cyberciti.biz - "How to write the output into the file in Linux"](https://www.cyberciti.biz/faq/how-to-write-the-output-into-the-file-in-linux/)