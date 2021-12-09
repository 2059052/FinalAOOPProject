# Final AOOP Project
### Nguyễn Phú Thành - 2059052
### Mail: 2059052@itec.hcmus.edu.vn
### Github: https://github.com/2059052/FinalAOOPProject
### Mức độ hoàn thiện: 70%


---
# Module soạn đề
### chức năng FormMain
- Nút Questions Bank chuyển tới FormQuestionbank (chỉnh sửa ngân hàng đề).
- Nút Create Quiz chuyển tới FormCreateQuiz(Soạn,xuất đề và đáp án).
- Nút Score chuyển tới Form Score(nhập file bài làm và file đáp án, xuất ra file txt có thông tin sinh viên và điểm).
- Và từ các form đó đều có nút back để về lại formMain.



### chức năng FormQuestionbank
-   Thêm, xóa, sửa câu hỏi, chủ đề, các câu trả lời dưới dạng text.
-   Save câu hỏi về file QuestionBank.xml để khi Form này load lên sẽ load ngân hàng đề lên.
-   Search câu hỏi .



### chức năng FormCreateQuiz
- Khi chọn số lượng câu hỏi, random lên List Selected Question các câu hỏi ngẫu nhiên theo đúng số lượng đã chọn.
- Ta cũng có thể tự chọn các câu hỏi bằng cách double-click vào câu hỏi ở listbox Quesion Bank.
- Và ngược lại thì double-click vào listbox Selected Question để remove các câu hỏi đó.
- Set id cho đề thi .
- Nút export Quiz có nhiệm vụ mở file explorer lên chọn nơi lưu và đặt tên cho file Đề Thi. 
- Nút export Answer có nhiệm vụ mở file explorer lên chọn nơi lưu và đặt tên cho file Đáp Án cho mã đề đó. 


### chức năng FormScore
- Nút Import file bài làm(mở folder lên và chọn file).
- Nút Import file đáp án(mở folder lên và chọn file).
- Nút Export result 
    - Check xem đã import đủ 2 file chưa.
    - Check id file bài làm và file đáp án có trùng không.
    - nếu thỏa hết điều kiện 
        - tính điểm
        - xuất file txt có thông tin sinh viên, điểm số và thời gian

---
# Module làm bài
### chức năng
- Nút Load dùng để load file xml đề thi lên.
- Nút Start cho uscClock chạy và bắt đầu tính giờ làm bài(hết thời gian làm bài,thông báo và tắt ứng dụng).
- User control uscQuestion load lên các câu hỏi và câu trả lời đã được lưu vào ListQuestion ở bước 1.
- Nút Back Next trong uscQuestion có nhiệm vụ tới lui câu hỏi và load câu hỏi mới lên Form (đồng thời lưu lại đáp án vào listAnswer thông qua các check box đã được chọn.
- Textbox name và student ID cho để nhập thông tin người làm bài
- Nút Submit(dựa trên thông tin người làm bài ở trên và các câu trả lời đã lưu ở listAnswer) mở file explorer lên chọn nơi để lưu và đặt tên file.
