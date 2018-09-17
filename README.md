# Auto number Markdown
Autonumbering of markdown documents with chapters, sections, subsections. It makes it easy to write longer structured documents in the editor while at the same time give you near "automatic" numbering.

Syntax: `AutonumberMarkdown [--sectionsOnly] [--makeToc] <filename>`

It reads the file and renumerate the chapters `#`, sections `##`, subsections `###`... of your markdown document.

Speed: roughly 1.000.000 lines a second (68mb) in 1 second on a simple core I5 gaming pc.


## Integrations

You can typically run exe files from within your favorite editor like

 **Notepad++**
  * Select `Run...`
  * program to run: `C:\util\AutonumberMarkdown.exe "$(FULL_CURRENT_PATH)"`
  * Name the short-cut and set keys for it
  


## Configuraiton

### --sectionsOnly
When using the `--sectionsOnly` flag, the tool only operates on sections, subsections and subsubsections.

### --makeToc
When using the `--makeToc` flag, the tool looks for the text "table of content" and replaces it with a new table of content. 


  
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


