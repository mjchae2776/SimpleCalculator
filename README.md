# (C# 코딩) 에코 메신저
## 개요

- C# 프로그래밍 학습

- 1줄 소개: 사용자 키보드 입력을 받아서 처리하는 프로그램

- 사용한 플랫폼:
C#, .NET Windows Forms, Visual Studio, GitHub

- 사용한 컨트롤:
Label, TextBox, ListBox, Button

- 사용한 기술과 구현한 기능:
Visual Studio를 이용하여 UI 디자인
string 클래스를 이용한 사용자 입력 데이터 처리
DateTime 클래스를 이용한 현재시간 정보 구하기


- 수업 중에 배우고 사용했던 클래스들 관련된 설명
Form 클래스

모든 Windows Forms 애플리케이션의 기본이 되는 클래스입니다. 사용자 인터페이스(UI)가 표시되는 창(Window) 그 자체를 의미하며, 컨트롤들을 배치하는 캔버스 역할을 합니다.

Control 클래스 (Button, TextBox, Label 등)

화면에 표시되는 모든 시각적 요소의 최상위 클래스입니다.

Button: 사용자의 클릭 이벤트를 받아 동작을 실행합니다.

TextBox: 사용자의 텍스트 입력을 받거나 계산 결과를 출력하는 창으로 사용됩니다. (txtDisplay, txtHistory 등)

String & Int32 (int) / Double 클래스

String: 텍스트 박스에 표시되는 모든 데이터는 문자열입니다. 이를 처리하기 위해 Substring, Length 등의 메서드를 사용했습니다.

int / double: 산술 연산을 위해 문자열을 숫자로 변환(Parse)하거나, 계산 결과를 다시 화면에 띄우기 위해 문자열로 변환(ToString)할 때 사용했습니다.

Math 클래스

C#에서 제공하는 정적 클래스로, 복잡한 수학 계산을 돕습니다. 이번 과제 4에서 Math.Sqrt()(제곱근) 기능을 구현할 때 필수적으로 사용되었습니다.

- 실습 중에 구현한 기능들 설명
1. 스마트 숫자 입력 기능 (2가지 방식)
교체(Replace): 계산기 초기 상태("0")이거나 연산자 버튼을 누른 직후에는 기존 값을 지우고 새 숫자를 씁니다.

추가(Append): 숫자가 입력 중인 상태에서는 기존 숫자 뒤에 새로운 숫자를 이어 붙입니다.

2. 사칙연산 및 예외 처리
사칙연산: +, -, *, / 연산자 클릭 시 첫 번째 피연산자를 저장하고 연산 종류를 기억한 뒤, = 클릭 시 최종 결과를 도출합니다.

0 나누기 방지: 나눗셈 연산 시 분모가 0일 경우 프로그램이 멈추지 않도록 MessageBox를 띄워 사용자에게 알리는 예외 처리를 구현했습니다.

3. 듀얼 텍스트 박스 동기화 및 수정 기능
기록창(txtHistory): 사용자가 입력한 전체 과정(예: 1 + 2 =)을 실시간으로 상단에 표시하여 계산 흐름을 파악하게 합니다.

C / CE / Del: 전체 초기화(C), 현재 입력값만 삭제(CE), 마지막 한 글자만 삭제(Del) 기능을 구현하여 사용자 입력 실수를 완벽하게 제어합니다. 이때 상단 기록창의 내용도 함께 지워지도록 동기화했습니다.

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷


![과제1 실행화면](img/a.png)
UI 구성

![과제1 실행화면](img/b.png)
숫자 5 입력

![과제1 실행화면](img/c.png)
더하기 버튼 누른 후 숫자 66 입력

![과제1 실행화면](img/d.png)
= 버튼을 누르면 덧셈 결과가 나옴

![과제1 실행화면](img/e.png)
= 버튼을 두번 누르면 초기화됨



-과제 내용

TextBox(입력 및 결과 표시), Button(숫자 및 연산) 등을 적절히 배치합니다.

숫자 버튼 클릭 시 텍스트박스에 숫자가 표시되는 기능을 2가지 방식(교체/추가)으로 구현합니다.

구현 내용 및 기능 설명

UI 구성: TableLayoutPanel을 사용하여 계산기 버튼을 격자 형태로 정렬.

입력 기능: 첫 숫자 입력 시 "0"을 지우고 쓰고, 이후 숫자는 뒤에 이어 붙임.

더하기 연산: 입력된 문자열을 Int로 변환하여 덧셈을 수행하고 결과를 다시 문자열로 출력.

## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷
<img width="479" height="496" alt="f" src="https://github.com/user-attachments/assets/1fc9332d-0c89-4453-9a54-7e9d4513b2c7" />


<img width="475" height="498" alt="g" src="https://github.com/user-attachments/assets/2de147b2-de32-4bd3-91ae-43e4652ea0d6" />


<img width="473" height="502" alt="h" src="https://github.com/user-attachments/assets/5e3e183b-e265-4111-a2d9-11b88d01fdbc" />

3에서 2를 빼서 1이 나옴

<img width="475" height="506" alt="i" src="https://github.com/user-attachments/assets/0ab183cf-ee07-437d-9c17-bbab47591152" />

<img width="478" height="497" alt="j" src="https://github.com/user-attachments/assets/1d617099-e0ff-4711-82d5-1deadabd52c2" />

<img width="478" height="498" alt="k" src="https://github.com/user-attachments/assets/9c3babe8-e2a3-441d-9145-9198fec9fc85" />


9에 5를 곱해서 45가 나옴

<img width="480" height="500" alt="l" src="https://github.com/user-attachments/assets/63efc39a-2634-40de-b89d-3b58f2c29483" />

<img width="481" height="495" alt="m" src="https://github.com/user-attachments/assets/8f56bc83-a901-4792-97f7-807a5d3172d2" />

<img width="474" height="496" alt="n" src="https://github.com/user-attachments/assets/f0a1cdfc-7e1b-406b-a30a-d48e6d2db33a" />

9를 3으로 나눠서 3이 나옴


-과제 내용

뺄셈, 곱셈, 나눗셈 기능을 추가하여 사칙연산을 완성합니다.

-구현 내용 및 기능 설명

연산자 처리: switch-case문을 사용하여 operation 변수에 담긴 기호에 따라 연산 분기 처리.

나눗셈 예외 처리: 두 번째 피연산자가 0일 경우 "0으로 나눌 수 없습니다"라는 경고 메시지(MessageBox) 출력.

공통 이벤트: 연산자 버튼들을 하나의 이벤트 핸들러로 묶어 코드 효율성 증대.


## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷
<img width="477" height="491" alt="3" src="https://github.com/user-attachments/assets/10b46cee-5ed1-44ad-ba46-738ee8d1fe43" />

<img width="474" height="504" alt="2" src="https://github.com/user-attachments/assets/7b30cf15-ccb9-4bf3-8964-64ce537712f1" />

<img width="474" height="504" alt="1" src="https://github.com/user-attachments/assets/115b296c-a289-4db5-92e0-05681ff7baf9" />

<img width="474" height="497" alt="5" src="https://github.com/user-attachments/assets/e75f5e9e-0512-4601-851e-03c409439536" />

<img width="481" height="496" alt="4" src="https://github.com/user-attachments/assets/e834f344-7a25-46b1-b7b5-34fdd39cd256" />

de 버튼을 사용하여 삭제 후 원래 입력되어있던 8까지 삭제하는 것이 아닌 잘못 입력한 5만 삭제함
5만 깔끔하게 삭제되어 8x6이 계산됨

<img width="478" height="495" alt="6" src="https://github.com/user-attachments/assets/44834d23-4c70-4151-906d-940f966ac04f" />

<img width="480" height="501" alt="7" src="https://github.com/user-attachments/assets/31b07f02-77c7-4371-8b34-631cb5d7f21e" />

c 버튼을 사용하여 현재의 모든 내용을 삭제하고 처음 (초기화된) 상태로 되돌아감

<img width="474" height="502" alt="8" src="https://github.com/user-attachments/assets/ff193e6d-28ea-47f2-80a7-10cc2517ee63" />

<img width="475" height="497" alt="9" src="https://github.com/user-attachments/assets/d822396e-889a-46ca-9e44-035126a341a8" />

del 버튼을 사용하여 마지막 입력된 글자 하나 (숫자 하나) 값을 삭제함


-과제 내용
계산기 초기화(C), 현재 입력 지우기(CE), 한 글자 지우기(Del) 기능을 추가합니다.

-구현 내용 및 기능 설명

전체 초기화(C): 모든 변수(firstNum, operation)와 텍스트박스를 초기 상태로 리셋.

입력 초기화(CE): firstNum은 유지한 채 현재 입력 중인 txtDisplay 내용만 "0"으로 초기화.

백스페이스(Del): Substring 메서드를 사용하여 텍스트박스의 마지막 문자를 제거. 글자가 모두 지워지면 "0"으로 표시.

## 실행 화면 (과제4)
- 과제4 코드의 실행 스크린샷
![과제4 실행화면](img/11.png)

![과제4 실행화면](img/22.png)

제곱 기능 추가

![과제4 실행화면](img/33.png)

![과제4 실행화면](img/44.png)

![과제4 실행화면](img/55.png)

제곱근 기능 추가


-과제 내용
기존 사칙연산 외에 수학적 특수 연산인 제곱 기능과 제곱근 기능을 추가함.
단항 연산자(숫자 하나를 입력받아 즉시 결과 출력)의 특성에 맞춰 UI와 로직을 설계함.


-구현 내용 및 기능 설명
제곱 연산: 현재 입력된 피연산자를 자기 자신과 곱하여 즉시 결과를 화면에 출력함.
제곱근 연산: Math.Sqrt 메서드를 사용하여 현재 숫자의 루트 값을 계산합니다. 음수 입력 시 MessageBox를 통해 예외 처리를 수행함.
연산 기록 동기화: 특수 연산 수행 시에도 상단 기록창(txtMessage)에 연산 과정(예: 5² = 25)이 실시간으로 업데이트되도록 구현함.
