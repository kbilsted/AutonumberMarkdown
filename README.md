# AutonumberMarkdown
Autonumbering of markdown documents with chapters, sections, subsections, ...

Syntax: `AutonumberMarkdown <filename>`

It reads the file and renumerate the chapters `#`, sections `##`, subsections `###`... of your markdown document.

Speed: roughly 1.000.000 lines a second (68mb) in 1 second on a simple core I5 gaming pc.




## Example translation of a markdown file

Turns files like

```
# Ultimate cooking in space

foo bar and more text...

## Making the perfect sandwich

Start with a fresh set of meteorites and moon dust

### Caveats

Remember, that in order to succeed, you need the full attention of both cook and assistants..

# The fears of an astronaut

There are many dangers in space, like aliens, black holes and such

## Aliens

Space is wastly big, and so are the space aliens that constantly monitor our every move

## Black holes

Black holes are the main transportation line out of the milky way. Rather than fear it, regard it a very reliable express train..

```

into

```
# 1. Ultimate cooking in space

foo bar and more text...

## 1.1 Making the perfect sandwich

Start with a fresh set of meteorites and moon dust

### 1.1.1 Caveats

Remember, that in order to succeed, you need the full attention of both cook and assistants..

# 2. The fears of an astronaut

There are many dangers in space, like aliens, black holes and such

## 2.1 Aliens

Space is wastly big, and so are the space aliens that constantly monitor our every move

## 2.2 Black holes

Black holes are the main transportation line out of the milky way. Rather than fear it, regard it a very reliable express train..


```


