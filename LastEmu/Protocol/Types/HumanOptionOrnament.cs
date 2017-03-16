using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionOrnament : HumanOption
	{
		public const short Id = 411;

		public uint ornamentId;

		public override short TypeId
		{
			get
			{
				return 411;
			}
		}

		public HumanOptionOrnament()
		{
		}

		public HumanOptionOrnament(uint ornamentId)
		{
			this.ornamentId = ornamentId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.ornamentId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.ornamentId);
		}
	}
}