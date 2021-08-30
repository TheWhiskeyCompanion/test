pipeline {
    agent any
    parameters {
        string(name: 'TeamProject', defaultValue: "ReleaseEngineering")
        string(name: 'ProjectRepository', defaultValue: "ArtifactTest")
    }
    stages {
        stage('get') {        
            steps {
                powershell(returnStdout: true, script: "& \$profile\n"
                + "Import-Module DockerPipeline -DisableNameChecking\n"
                + "Set-JenkinsVariables -ProjectRepository ${params.ProjectRepository} -TeamProject ${params.TeamProject} -Branch master\n"
                + "Create-BomiArtifactPipeline -CI -branch master\n"
                + "Initialize-Container -BuildJob get -JobStage pre\n"
                + "Initialize-Container -BuildJob get -JobStage post\n")
            }
        }
        stage('build') {           
            steps {
                powershell(returnStdout: true, script: "Import-Module DockerPipeline -DisableNameChecking\n"
                + "Set-JenkinsVariables -ProjectRepository ${params.ProjectRepository} -TeamProject ${params.TeamProject} -Branch master -RemoveYml\n"
                + "Initialize-Container -BuildJob build -JobStage pre\n"
                + "Initialize-Container -BuildJob build -JobStage post\n")
            }
        }
    }
}