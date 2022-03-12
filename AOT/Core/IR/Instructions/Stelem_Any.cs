using SharpOS.AOT.IR.Operands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpOS.AOT.IR.Instructions
{

	/// <summary>
	/// 
	/// </summary>
	public class Stelem_Any : Instruction
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Ldflda"/> class.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <param name="index">Array's index.</param>
		/// <param name="arrayRef">Array reference.</param>
		public Stelem_Any(Class type, Register result, Register index, Register arrayRef) : base("Stelem.Any", result, new Operand[] { arrayRef, index })
		{
			this.type = type;
		}

		Class type;

		/// <summary>
		/// Gets the type.
		/// </summary>
		/// <value>The type.</value>
		public Class Type
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>
		/// Processes the specified method.
		/// </summary>
		/// <param name="method">The method.</param>
		public override void Process(Method method)
		{
			if (this.type.IsClass || this.type.IsValueType)
			{
				this.def.InternalType = InternalType.M;
				this.def.Type = type;

			}
			else
				throw new NotImplementedEngineException("Type " + this.Type + " can't be handled by Stelem_Any");
		}
	}
}
