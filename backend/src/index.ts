import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';
import path from 'path';

const app = express();
const PORT = 3000;

app.use(bodyParser.json());

interface Submission {
  name: string;
  email: string;
  phone: string;
  githubLink: string;
  stopwatchTime: string;
}

const dbFilePath = path.join(__dirname, 'db.json');

app.get('/ping', (req: Request, res: Response) => {
  res.send(true);
});

app.post('/submit', (req: Request, res: Response) => {
  const newSubmission: Submission = req.body;
  const submissions = readSubmissions();
  submissions.push(newSubmission);
  writeSubmissions(submissions);
  res.sendStatus(200);
});

app.get('/read', (req: Request, res: Response) => {
  const index = parseInt(req.query.index as string);
  const submissions = readSubmissions();
  if (index >= 0 && index < submissions.length) {
    res.json(submissions[index]);
  } else {
    res.sendStatus(404);
  }
});

function readSubmissions(): Submission[] {
  if (fs.existsSync(dbFilePath)) {
    const data = fs.readFileSync(dbFilePath, 'utf8');
    return JSON.parse(data);
  }
  return [];
}

function writeSubmissions(submissions: Submission[]) {
  fs.writeFileSync(dbFilePath, JSON.stringify(submissions, null, 2));
}

app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});
