# import threading
# import time
# import keyboard
# import pyautogui
#
#
#
# while True:
#     if keyboard.is_pressed('space'):
#         pyautogui.click()  # Simulate a single mouse click
#         print("點擊中")
#     else:
#             print("停止點擊")
#     time.sleep(0.01)
#



import win32api, win32con
import time
import keyboard

def click():
    x, y = win32api.GetCursorPos()  # 獲取當前滑鼠的座標
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTDOWN, x, y, 0, 0)
    win32api.mouse_event(win32con.MOUSEEVENTF_LEFTUP, x, y, 0, 0)

while True:
    if keyboard.is_pressed('space'):
        click()  # 在滑鼠當前的位置進行點擊
        print("點擊中")
    else:
        print("停止點擊")
    time.sleep(0.001)  # 更快的點擊速度

