using Protocol.IO;

using System;

namespace Protocol.Types
{
	public class FightOptionsInformations
	{
		public const short Id = 20;

		public bool isSecret;

		public bool isRestrictedToPartyOnly;

		public bool isClosed;

		public bool isAskingForHelp;

		public virtual short TypeId
		{
			get
			{
				return 20;
			}
		}

		public FightOptionsInformations()
		{
		}

		public FightOptionsInformations(bool isSecret, bool isRestrictedToPartyOnly, bool isClosed, bool isAskingForHelp)
		{
			this.isSecret = isSecret;
			this.isRestrictedToPartyOnly = isRestrictedToPartyOnly;
			this.isClosed = isClosed;
			this.isAskingForHelp = isAskingForHelp;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.isSecret = BooleanByteWrapper.GetFlag(num, 0);
			this.isRestrictedToPartyOnly = BooleanByteWrapper.GetFlag(num, 1);
			this.isClosed = BooleanByteWrapper.GetFlag(num, 2);
			this.isAskingForHelp = BooleanByteWrapper.GetFlag(num, 3);
		}

		public virtual void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.isSecret);
			num = BooleanByteWrapper.SetFlag(num, 1, this.isRestrictedToPartyOnly);
			num = BooleanByteWrapper.SetFlag(num, 2, this.isClosed);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 3, this.isAskingForHelp));
		}
	}
}