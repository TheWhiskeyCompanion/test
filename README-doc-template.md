# AsciidocTemplate

This repo holds files and skin for documentation written using Asciidoctor and published to [http://docserver](http://docserver).

**Note** that currently only "bomiArtifact" repos are supported.


### Prereqs:

* for editing, recommend an editor with Asciidoc support.  The [setup guide](http://docserver/ReleaseEngineering/DeveloperGuide/setting-up/pc-setup-guide/pc-setup-guide.html#jetbrains-intellij-(for-asciidoc)) explains how to install IntelliJ or AsciidocFX.
     
* for local previewing, install JDK8, Maven and python3.  The [setup guide](http://docserver/ReleaseEngineering/DeveloperGuide/setting-up/pc-setup-guide/pc-setup-guide.html#chocolatey) in the Developers' Guide also explains how (using Chocolatey, it's basically just: `choco install -y jdk8 maven python3`)

* read the [markup-docs section](http://docserver/ReleaseEngineering/DeveloperGuide/guides/markup-docs/markup-docs.html) in the Developers' Guide on how to write Asciidoc documentation 


### To setup

* copy over the `src` directory from this repo into your existing git repo

* Update the `.gitignore` config file manually (create one if none exists), adding in:

<pre>
    src/main/asciidoc/css/
    src/main/asciidoc/js/
    src/main/asciidoc/img/
    src/main/template/
    lib/
    target/
    pom-html.xml
    pom-pdf.xml
</pre>


* Update the `artifact.yml` config file manually (create one if none exists), adding in:

<pre>
docs: true
documentation:
  website_title: My Cool Repo
  navbar: src/main/html/navbar.html
</pre>

* Update the `website_title` in `artifact.yml` (above).

* Update the content under `src/main/asciidoc`.
The template provides a couple of simple documents to get you started.

* Update the `src/main/html/navbar.html`, linking to the most useful content.

* Update the CI pipeline references in `src/main/asciidoc/index.adoc`.

* Search for any "TODO"s remaining and update.

* Delete this README file.


### Authoring

To author your website:

* write Asciidoc docs in `src/main/asciidoc`
 
* update `artifact.yml` file, specifically:

    * `docs: true`
    * `documentation.website_title: My cool repo`
    * `documentation.navbar: src/main/html/navbar.html`

* update the navigation bar snippet, `src/main/html/navbar.html`


To preview locally:

* use `Build-Docs -Preview`



### Publishing

When you commit and push your changes, the build pipeline for your repo will automatically notice the documentation and build and publish it to link:http://docserver[docserver].  This will also automatically be indexed for searching, and added to the top-level site map.

