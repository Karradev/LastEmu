using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class KrosmasterFigure
	{
		public const short Id = 397;

		public string uid;

		public uint figure;

		public uint pedestal;

		public bool bound;

		public virtual short TypeId
		{
			get
			{
				return 397;
			}
		}

		public KrosmasterFigure()
		{
		}

		public KrosmasterFigure(string uid, uint figure, uint pedestal, bool bound)
		{
			this.uid = uid;
			this.figure = figure;
			this.pedestal = pedestal;
			this.bound = bound;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.uid = reader.ReadUTF();
			this.figure = reader.ReadVarUhShort();
			this.pedestal = reader.ReadVarUhShort();
			this.bound = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.uid);
			writer.WriteVarShort((int)this.figure);
			writer.WriteVarShort((int)this.pedestal);
			writer.WriteBoolean(this.bound);
		}
	}
}