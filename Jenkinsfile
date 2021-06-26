
pipeline {
    agent any
    when { anyOf { branch 'main'; branch 'test' } }
        stages {
            stage('ScriptStage') {
                steps {
                    parallel (
                    "TaskOne" : {
                        echo 'task one stuff part 1'
                        echo 'task one stuff part 2'
                        echo 'task one stuff part 3'
                        when {
                        branch 'main'
                        anyOf {
                            environment name: 'DEPLOY_TO', value: 'main'
                            echo 'deploy to main environment'
                        }
                        }
                    },
                    "TaskTwo" : {
                        echo 'tasl two stuff part 1'
                        echo 'tasl two stuff part 2'
                        when {
                        branch 'test'
                        anyOf {
                            environment name: 'DEPLOY_TO', value: 'test'
                            echo 'deploy to test environment'
                        }
                        }
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
