using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSharp.Builder
{
    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void construct()
        {
            builder.makeTitle("Greeting");
            builder.makeString("아침과 낮에");
            builder.makeItems(new string[]
            {
                "좋은 아침입니다.",
                "안녕하세여"
            });
            builder.makeString("밤에");
            builder.makeItems(new string[]
            {
                "안녕하세요.",
                "연녕히 주무세요.",
                "안녕히 계세요"
            });
            builder.close();
        }
    }
}
