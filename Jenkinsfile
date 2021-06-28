agent any
environment {
   MainEnvConfig = 'someconfig'
   dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'
}
stages {
   stage('Env') {
	when {
	   branch 'develop'
	}
	steps {
	   echo "we need to do ${MainEnvConfig} in order to make it work"
	}
   }
   stage('Scripts') {
    steps {
	   script {
	   def a = 5
	   println a
	   if (a>3)
	   {
		println "a jest wieksze od 3"
	   }
	   else
	   {
		println "a jest mniejsze badz rowne 3"
	   }
	   }
	   parallel (
		"TaskOne" : {
		   echo 'task 1 stuff part 1'
		   echo 'task 1 stuff part 2'
		}
		"TaskTwo" : {
		   echo 'task 2 stuff part 1'
		   echo 'task 2 stuff part 2'
		}
	   )
	}
   }
   stage('Build') {
	steps {
	   dir("Calculator") {
   	      bat "${dotnet} build"
	   }
	}
   }
   stage('Tests') {
	steps {
	   dir("CalculatorTests") {
   	      bat "${dotnet} test"
	   }
	}
   }
   stage('Clean') {
	steps {
	   dir("Calculator") {
   	      bat "${dotnet} clean"
	   }
	}
	steps {
	   dir("CalculatorTests") {
   	      bat "${dotnet} clean"
	   }
	}
   }
   post {
	always {
	   echo "to zawsze bedzie wykonane"
	}
	success {
	   echo "to bedzie wykonane w razie sukcesu"
	   mail to: 'krzysztof.nowacki@posti.com',
	   subject: "build info",
	   body: "build success"
	}
	failure {
	   echo "to bedzie wykonane w razie faila"
	   echo "jesli to widzisz, to niestety był gdzieś fail :("
	}
   }
}