#!/bin/bash

dotnet lambda deploy-serverless \
  --stack-name FreelanceDirekt-Website \
  --s3-bucket dnw-templates-2022

aws cloudfront create-invalidation \
  --distribution-id E2QX4I5USJMB9G \
  --paths "/*"