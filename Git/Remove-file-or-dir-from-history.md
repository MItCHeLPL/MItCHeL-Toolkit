# Remove directory or files from all commits + history and push it to GitHub

## Install filter-repo python package
[Installation](https://github.com/newren/git-filter-repo)

## Filter your repository
```shell
git filter-repo --path [directory/] --path [file] --invert-paths
```
[Other examples](https://htmlpreview.github.io/?https://github.com/newren/git-filter-repo/blob/docs/html/git-filter-repo.html#EXAMPLES)

## Check commit history
```shell
git log -p #see all changes for each commit
git log --name-only #see commits + changed file names
```

## By using `filter-repo` our repository disconnected from origin so we have to re-set origin
**Using HTTP**
```shell
git remote set-url origin https://github.com/[user]/[repository-name].git
```
or by  
**Using SSH**
```shell
git remote add origin git@github.com:[user]/[repository-name].git
```

## If all changes are correct overwrite remote repository
```shell
git push origin --force --all
```

## Now remote repository is corrected, but local branches may still be disconnected from remote ones
### To fix it use
```shell
git branch -D [branch-name] #remove local branch (You have to be on other branch to delete branch)
git switch [branch-name] #get remote branch and create new local synced branch
```

## Useful git commands regarding branches
### See all local branches
```shell
git branch
```

### See all remote branches
```shell
git branch -r
```

### Switch branch
```shell
git checkout [branch-name]
```

## Useful links
* [GitHub docs - "Removing sensitive data from a repository"](https://docs.github.com/en/github/authenticating-to-github/keeping-your-account-and-data-secure/removing-sensitive-data-from-a-repository)