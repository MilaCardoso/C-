using System.Collections.Generic;
namespace hello{
    class Question{
        List<string> questions;
        List<string> answers;
        public Question(){
            questions = new List<string>();
            answers = new List<string>();
        }
        public void AddQuestion(string q){
            this.questions.Add(q);
        }
        public void AddAnswer(string a){
            this.answers.Add(a);
        }
        public List<string> ReadQuestionAll(){
            return questions;
        }

        public List<string> ReadAnswersAll(){
            return answers;
        }

    }
}