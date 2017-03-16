using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class DareSubscribedMessage : NetworkMessage
	{
		public const uint Id = 6660;

		public bool success;

		public bool subscribe;

		public double dareId;

		public DareVersatileInformations dareVersatilesInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6660;
			}
		}

		public DareSubscribedMessage()
		{
		}

		public DareSubscribedMessage(bool success, bool subscribe, double dareId, DareVersatileInformations dareVersatilesInfos)
		{
			this.success = success;
			this.subscribe = subscribe;
			this.dareId = dareId;
			this.dareVersatilesInfos = dareVersatilesInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.success = BooleanByteWrapper.GetFlag(num, 0);
			this.subscribe = BooleanByteWrapper.GetFlag(num, 1);
			this.dareId = reader.ReadDouble();
			this.dareVersatilesInfos = new DareVersatileInformations();
			this.dareVersatilesInfos.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.success);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.subscribe));
			writer.WriteDouble(this.dareId);
			this.dareVersatilesInfos.Serialize(writer);
		}
	}
}