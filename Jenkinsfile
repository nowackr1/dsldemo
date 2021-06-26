
pipeline {
    agent any
        stages {
            stage('ScriptStage') {
                steps {
                    parallel (
                    "Taskone" : {
                        echo 'task one stuff'
                    },
                    "Tasktwo" : {
                        echo 'tasl two stuff'
                    }
                    )
            }
            }
            stage('Build') {
                steps {
                    echo 'Building....'
                }
            }
            stage('Test') {
                steps {
                    echo 'Testing....'
                }
            }
            stage('Clean') {
                steps {
                    echo 'Cleaning....'
                }
            }
    }
}
