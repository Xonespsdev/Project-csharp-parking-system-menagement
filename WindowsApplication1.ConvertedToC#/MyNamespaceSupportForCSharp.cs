using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

// This file was created by the VB to C# converter (SharpDevelop 4.4.2.9749).
// It contains classes for supporting the VB "My" namespace in C#.
// If the VB application does not use the "My" namespace, or if you removed the usage
// after the conversion to C#, you can delete this file.

namespace WindowsApplication1.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::WindowsApplication1.frmLogin frmLogin_instance;
			bool frmLogin_isCreating;
			public global::WindowsApplication1.frmLogin frmLogin {
				[DebuggerStepThrough] get { return GetForm(ref frmLogin_instance, ref frmLogin_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmLogin_instance, value); }
			}
			
			
			global::WindowsApplication1.MainComponentForm MainComponentForm_instance;
			bool MainComponentForm_isCreating;
			public global::WindowsApplication1.MainComponentForm MainComponentForm {
				[DebuggerStepThrough] get { return GetForm(ref MainComponentForm_instance, ref MainComponentForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref MainComponentForm_instance, value); }
			}
			
			global::WindowsApplication1.frmReportMember frmBillMember_instance;
			bool frmBillMember_isCreating;
			public global::WindowsApplication1.frmReportMember frmBillMember {
				[DebuggerStepThrough] get { return GetForm(ref frmBillMember_instance, ref frmBillMember_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref frmBillMember_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			Application.Run(new MainComponentForm());
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}
