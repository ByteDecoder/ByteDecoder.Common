#!/bin/sh
set -e

SOURCE_DIR=$PWD/../docs
TEMP_REPO_DIR=$PWD/../gh-pages

echo "Removing temporary doc directory $TEMP_REPO_DIR"
rm -rf $TEMP_REPO_DIR
mkdir $TEMP_REPO_DIR

echo "Cloning the repo with the gh-pages branch"
git clone https://${BYTEDECODER_COMMON_GITHUB_CI_ACTIONS}:x-oauth-basic@github.com/ByteDecoder/ByteDecoder.Common.git --branch gh-pages $TEMP_REPO_DIR

echo "Clear repo directory"
cd $TEMP_REPO_DIR
git rm -r *

echo "Copy documentation into the repo"
cp -r $SOURCE_DIR/../docs/_site/* .

echo "Push the new docs to the remote branch"
git config --global user.email ${DOCFX_GITHUB_EMAIL}
git config --global user.name "ByteDecoder"

git add . -A
git diff-index --quiet HEAD || git commit -m "Update generated documentation" || git push origin gh-pages
