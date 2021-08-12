# Remove commits from history and push it to GitHub

## We have to use `git rebase`:
```shell
git rebase --onto [first-commit-hash-to-remove] [first-commit-hash-to-be-kept] [branch-name]
```

### For example if we have commits from 1 to 5 and we want to remove 2nd and 3rd commit:
```shell
git rebase --onto [3rd-commit-hash] [1st-commit-hash] [branch-name]
```

## Now every time git encounters conflict we have to resolve it manually, then type
```shell
git rebase --continue
```

### If something went wrong during rebase use
```shell
git rebase --abort
```

## Check commit history
```shell
git log -p #see all changes for each commit
git log --name-only #see commits + changed file names
```

## If all changes are correct overwrite remote repository
```shell
git push origin [branch-name] --force
```

## Useful links
* [clock. - "Deleting a git commit"](https://www.clock.co.uk/insight/deleting-a-git-commit)
* [Stack Overflow - "Remove specific commit"](https://stackoverflow.com/questions/2938301/remove-specific-commit)