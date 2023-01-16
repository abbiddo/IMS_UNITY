# IMS_UNITY

<details>
  <summary> 코루틴 </summary>
  
  ```
  < 코루틴 >
    
  원하는 순간에만 코듣를 반복적으로 실행하기 위해 사용
  (일정 시간 멈춰 있기 등)
  ```
    
  ```
  < 코루틴 선언 >
    
  반환형   : IEnumerator
  반환     : yield return
  반환 값  : 반환 시간 (지연시킬 시간)
    - null : 1frame
    - new WaitForSeconds(s) : s초
    
  IEnumerator 코루틴 이름() {
    yield return 값;  
  }
  ```
    
  ```
  < 코루틴 실행 >
    
  StartCoroutine() 메소드 이용
  StartCoroutine("코루틴 이름");  
  StartCoroutine(코루틴 이름());
  ```
    
  ```
  < 코루틴 중지 >
    
  StopCoroutine("코루틴 이름");  // 해당 코루틴만 중지
  StopAllCoroutines();    // 모든 코루틴 중지
  ```
  
</details>


<details>
  <summary> 싱글톤 </summary>
  
  ```
  < 싱글톤 >
    
  게임 시스템의 전역 변수 역할을 하는 스크립트
  여러 오브젝트가 접근을 해야 하는 스크립트
  새로운 씬 로드 시 데이터 유지
  단 한개의 객체만 존재
  
  메모리 절약, 데이터 관리이 유용하다는 장점
  
  GameManager.instance.변수 혹은 함수명 으로 사용
  ```
  
  
</details>
