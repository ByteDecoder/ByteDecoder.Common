#!/bin/sh
set -e

SOURCE_DIR=$PWD/../docs
TEMP_REPO_DIR=$PWD/../gh-pages

echo "Removing temporary doc directory $TEMP_REPO_DIR"
# rm -rf $TEMP_REPO_DIR
# mkdir $TEMP_REPO_DIR

echo "Clear repo directory"
cd $TEMP_REPO_DIR
git rm -r *

echo "Copy documentation into the repo"
cp -r $SOURCE_DIR/../docs/_site/* .
