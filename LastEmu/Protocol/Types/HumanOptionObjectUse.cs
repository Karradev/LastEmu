using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class HumanOptionObjectUse : HumanOption
	{
		public const short Id = 449;

		public sbyte delayTypeId;

		public double delayEndTime;

		public uint objectGID;

		public override short TypeId
		{
			get
			{
				return 449;
			}
		}

		public HumanOptionObjectUse()
		{
		}

		public HumanOptionObjectUse(sbyte delayTypeId, double delayEndTime, uint objectGID)
		{
			this.delayTypeId = delayTypeId;
			this.delayEndTime = delayEndTime;
			this.objectGID = objectGID;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.delayTypeId = reader.ReadSByte();
			this.delayEndTime = reader.ReadDouble();
			this.objectGID = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.delayTypeId);
			writer.WriteDouble(this.delayEndTime);
			writer.WriteVarShort((int)this.objectGID);
		}
	}
}