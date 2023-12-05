# 레트로의 유니티 게임 프로그래밍 에센스

## Dodge

### Which components does it have

1. Game Manager
2. Level
3. Player  
3-1. Player Controller
4. Bullet Spawner and bullet
5. UI 

### Functions

- 게임 플레이 화면
<img src="./Picture/Ingame.png" title="Ingame"/>  
1. 파란 캡슐은 플레이어, 빨간 원통은 총알 생성기, 빨간 구는 총알입니다.  
1-1. 빨간 총알 생성기가 플레이어쪽으로 총알을 생성 및 발사합니다.  
1-2. 플레이어는 총알에 닿으면 게임 오버됩니다.<br/><br/>
2. 플레이어가 버틴 시간이 UI로 표시됩니다.  
<br/><br/>
- 게임 오버 화면
<img src="./Picture/Gameover.png" title="Gameover"/>  
1. 게임오버 텍스트가 표시됩니다.
2. 최고 기록(초)가 표기됩니다.

### What did I learn

1. 씬 구성하기  
1-1. Plane 만들기  
1-2. Material 만들기 + Plane에 적용  
1-3. Cube로 벽 만들기  
1-4. Parent Object 만들어 정리하기<br/><br/>
2. 카메라 설정하기  
2-1. Camera 배치하기  
2-2. Solid Color로 배경 변경하기<br/><br/>
3. 플레이어 제작  
3-1. Player GameObject 만들기  
3-2. Player Color Material 만들기 + Player에 적용  
3-3. Player 태그 할당  
3-4. RigidBody 컴포넌트 추가 및 제약 설정<br/><br/>
4. 플레이어 스크립트 생성  
4-1. PlayerController 스크립트 생성 및 변수 할당<br/><br/>
5. 사용자 입력 감지  
5-1. Update Method에 Input.GetKey(Keycode..) 메서드 사용<br/><br/>
6. 플레이어 사망 처리  
6-1. SetActive() 메서드 사용  
6-2. PlayerController 스크립트를 Player의 컴포넌트로 추가  
6-3. RigidBody 컴포넌트를 PlayerController 컴포넌트에 할당<br/><br/>
7. PlayerController 스크립트 개선  
7-1. private 한정자 사용  
7-2. GetAxis() 메서드 사용  
7-3. GetAxis() 메서드로 반환된 입력값 Vector3로 변환  
7-4. RigidBody의 AddForce()와 velocity 차이점 확인<br/><br/>
8. 입력 매니저  
8-1. 입력 매니저와 GetAxis() 메서드의 연관성 확인  
8-2. 입력 매니저와 축 확인  
8-3. 멀티플랫폼 입력 지원 확인  
9. 탄알 게임 오브젝트 준비  
9-1. Bullet GameObject + Material + RigidBody 생성  
9-2. Trigger Collider 적용  
9-3. Bullet을 Prefab 화<br/><br/>
10. 탄알 스크립트 준비
10-1. Bullet 스크립트 생성  
10-2. Start() 메서드 사용
10-3. Destroy() + 시간 파라미터 메서드 사용  
10-4. OnCollision, OnTrigger 차이점 학습, OnTriggerEnter() 메서드 사용  
10-5. Prefab override 적용<br/><br/>
11. 탄알 생성기 준비  
11-1. FindObjectOfType() 메서드 사용  
11-2. Update() 메서드의 실행 시간 간격 이해 + Time.deltaTime 변수 이해  
11-3. Instantiate() 메서드 사용  
11-4. LookAt() 메서드 사용  
11-5. Random.Range() 메서드 사용<br/><br/>
12. 프로젝트 정리  
12-1. Unity 프로젝트 폴더 정리<br/><br/>
13. 바닥 회전  
13-1. transform.Rotate() 메서드 사용  
13-2. Time.deltaTime 변수 사용<br/><br/>
14. 게임 UI 제작
14-1. Legacy->Text 오브젝트 생성  
14-2. Canvas와 EventSystem GameObject 이해  
14-3. Anchor Presets로 Text 정렬, Snapping 사용  
14-4. Text 내용 변경, Alignment, 폰트 컬러, 크기 변경  
14-5. Text Shadow 효과 적용<br/><br/>
15. 게임 매니저 제작  
15-1. Text.text 필드 접근  
15-2. SceneManager.LoadScene() 메서드 사용  
15-3. PlayerPrefs.GetFloat/SetFloat 사용<br/><br/>
16. 빌드  
16-1. Build and Run으로 빌드  
