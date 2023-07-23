# Get updates from main source repository

1.) Add the remote, call it "upstream": `git remote add upstream https://github.com/JKorf/Bybit.Net.git`  
2.) Fetch all the branches of that remote into remote-tracking branches, such as upstream/main: `git fetch upstream`  
3.) Make sure that you're on your main branch: `git checkout main`  
4.) Optional: Rewrite your main branch so that any commits of yours that aren't already in upstream/main are replayed on top of that other branch: `git rebase upstream/main`  
5.) Merge upstream/main into your main branch: `git merge upstream/main`
6.) Push your updated main branch to origin: `git push origin main`