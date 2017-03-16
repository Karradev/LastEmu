using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffectMount : ObjectEffect
	{
		public const short Id = 179;

		public int mountId;

		public double date;

		public uint modelId;

		public override short TypeId
		{
			get
			{
				return 179;
			}
		}

		public ObjectEffectMount()
		{
		}

		public ObjectEffectMount(uint actionId, int mountId, double date, uint modelId) : base(actionId)
		{
			this.mountId = mountId;
			this.date = date;
			this.modelId = modelId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.mountId = reader.ReadInt();
			this.date = reader.ReadDouble();
			this.modelId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.mountId);
			writer.WriteDouble(this.date);
			writer.WriteVarShort((int)this.modelId);
		}
	}
}